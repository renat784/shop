import { DataService } from './../data.service';
import { SearchService } from './../search.service';
import { Component, Inject, OnInit, ViewChild } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { Location } from '@angular/common';
import { NgForm } from '@angular/forms';

@Component({
  selector: 'app-search',
  templateUrl: './search.component.html',
  styleUrls: ['./search.component.css']
})
export class SearchComponent implements OnInit {
  ads: Ad[] = [];
  cities: City[] = [];
  cityId = 0;
  subCategories: SubCategory[] = [];
  // array that shows subcategory in select filtered by categoryId
  _subCategories: SubCategory[] = [];
  subCategoryId = 0;
  Categories: Category[] = [];
  categoryId = 0;
  // '-1' keyword for searching without limit in 'Price' min
  priceMin = -1;
  // '-1' keyword for searching without limit in 'Price' max
  priceMax = -1;
  filterUrl: string;
  // 'all' - keyword for searching without limit in 'Title'
  search: string = 'all';
  // helps to set values into form from search request
  @ViewChild('searchForm', null) public searchForm: NgForm;
  _ads : Ad[] = [];
  adsForPage = 20;

  constructor(@Inject('BASE_URL') public baseUrl: string, public router: Router, public searchService: SearchService, public location: Location, public dataService: DataService, public route: ActivatedRoute) {
    this.dataService.findCategories().subscribe(i => this.Categories = i);
    this.dataService.findCities().subscribe(i => this.cities = i);
  }

  ngOnInit() {
    // gets subcategories when we loading this component
    this.dataService.findSubCategories().subscribe(i => {
      this.subCategories = i;
      this.instant_search();
    });
  }

  instant_search() {
    // instant search after switching to this component
    let catid = this.route.snapshot.params.catid;
    let subcatid = this.route.snapshot.params.subcatid;
    let word = this.route.snapshot.params.word;
    let city = this.route.snapshot.params.city;

    // empty request: localhost/search
    if (catid == undefined && subcatid == undefined && word == undefined && city == undefined) return;

    // non emty request
    if (catid != undefined) this.categoryId = catid;
    if (subcatid != undefined) this.subCategoryId = subcatid;
    if (word != undefined) this.search = word;
    if (city != undefined) this.cityId = city;

    let filterUrl = this.baseUrl + 'ads/SearchByFilter/' +
      this.search + '/' +
      this.categoryId + '/' +
      this.subCategoryId + '/' +
      this.cityId + '/' +
      this.priceMin + '/' +
      this.priceMax + '/';

    // finds all ads and adds them to 'ads' array
    this.searchService.findAds(filterUrl);
    this.searchService.result_Observer.subscribe(i => {
      this.ads = i;
      this.ShowFirstResults();
    });

    // sets values into form from request
    if (this.search != 'all') {
      this.searchForm.controls["search"].setValue(this.search);
    }

    this.searchForm.controls["city"].setValue(this.cityId);
    this.searchForm.controls["category"].setValue(this.categoryId);
    this._subCategories = this.subCategories.filter(i => i.categoryId == this.categoryId);
    this.searchForm.controls["subCategory"].setValue(this.subCategoryId);
  }

  // sort 'ads' array by Asc order
  SearchByAscOrder() {
    this.ads = this.ads.sort((i, j) => i.price - j.price);
    this.ShowFirstResults();
  }

  // sort 'ads' array by Desc order
  SearchByDescOrder() {
    this.ads = this.ads.sort((i, j) => j.price - i.price);
    this.ShowFirstResults();
  }

  //  shows first 'adsForPage' search results
  ShowFirstResults(){
    this._ads = this.ads.slice(0, this.adsForPage);
  }

  //  adds additional 'adsForPage' search results to previous results
  AddMoreResults(){
      this._ads = this.ads.slice( 0, this._ads.length + this.adsForPage);
  }

  onClickSubmit(formData) {
    if (formData.priceMin == null || formData.priceMin == undefined || formData.priceMin == '') this.priceMin = -1;
    else this.priceMin = formData.priceMin;

    if (formData.priceMax == null || formData.priceMax == undefined || formData.priceMax == '') this.priceMax = -1;
    else this.priceMax = formData.priceMax;

    if (formData.search != "") {
      this.search = formData.search.trim();
    }
    else this.search = "all";

    this.filterUrl = this.baseUrl + 'ads/SearchByFilter/' +
      this.search + '/' +
      this.categoryId + '/' +
      this.subCategoryId + '/' +
      this.cityId + '/' +
      this.priceMin + '/' +
      this.priceMax + '/';

    this.searchService.findAds(this.filterUrl);
    this.searchService.result_Observer.subscribe(i =>{
       this.ads = i;
       this.ShowFirstResults();
    });
    // replaces url for the case when we return to it again from another component
    this.location.replaceState('/search/' + this.search + '/' + this.categoryId + '/' +
    this.subCategoryId + '/' + this.cityId);
  }

  filterCategories() {
    // subcategoryId must be set to '0' when we change category in case we want the search from whole category
    this.subCategoryId = 0;
    // changes array for subcategory select
    this._subCategories = this.subCategories.filter(i => i.categoryId == this.categoryId);
  }

  // navigation to top when ads to many
  toTop() {
    window.scrollTo(0, 0);
  }

  // navigation to search results
  toResults() {
    window.scrollTo(0, 450);
  }
}