import { concat } from 'rxjs';
import { DataService } from './../data.service';
import { SearchService } from './../search.service';
import { HttpClient } from '@angular/common/http';
import { Component, Inject, HostListener, OnInit, ViewChild } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { DetailsService } from '../details.service';
import {Location} from '@angular/common';
import { NgForm } from '@angular/forms';

@Component({
  selector: 'app-search',
  templateUrl: './search.component.html',
  styleUrls: ['./search.component.css']
})
export class SearchComponent  implements OnInit{
  imageExample = "https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcQ-eXU7nuTNc2WpFt58LTyr7Cjx5hX_TfR09KFMDZu3dDbknnF6&usqp=CAU";
  // ads = { city: {} as City, category: {} as Category, subCategory: {} as SubCategory } as Ad;
  ads: Ad[] = [];


  cities: City[] = [];
  cityId = 0;
  subCategories: SubCategory[] = [];
  _subCategories: SubCategory[] = [];
  subCategoryId = 0;
  Categories: Category[] = [];
  categoryId = 0;
  orderAsc = 1;
  priceMin = -1;
  priceMax = -1;
  filterUrl: string;
  search: string = 'all';
  @ViewChild('searchForm', null) public searchForm: NgForm;
  

  constructor(@Inject('BASE_URL') public baseUrl: string, public router: Router, 
  public searchService: SearchService, public location: Location,
  public dataService: DataService, public route: ActivatedRoute) {

    
    this.dataService.findCategories().subscribe(i => this.Categories = i);
    this.dataService.findCities().subscribe(i => this.cities = i);
  }


  ngOnInit() {
    this.dataService.findSubCategories().subscribe(i => {
      this.subCategories = i;
      this.instant_search();
    }
      );
   

   


  }
  instant_search() {
    // instant search
    let catid = this.route.snapshot.params.catid;
    let subcatid = this.route.snapshot.params.subcatid;
    let word = this.route.snapshot.params.word;
    let city = this.route.snapshot.params.city;

    if (catid != undefined) this.categoryId = catid;
    if (subcatid != undefined) this.subCategoryId = subcatid;
    if ( word != undefined) this.search = word;
    if (city != undefined) this.cityId = city;

    let filterUrl = this.baseUrl + 'ads/SearchByFilter/' +
      this.search + '/' +
      this.categoryId + '/' +
      this.subCategoryId + '/' +
      this.cityId + '/' +
      this.priceMin + '/' + 
      this.priceMax + '/';

    this.searchService.findAds(filterUrl);
    this.searchService.result_Observer.subscribe(i => this.ads = i);

   

    
    setTimeout(() => { 
      if(this.search != 'all'){
        this.searchForm.controls["search"].setValue(this.search);
      }
      
      this.searchForm.controls["city"].setValue(this.cityId);

      this.searchForm.controls["category"].setValue(this.categoryId);

      this._subCategories = this.subCategories.filter(i => i.categoryId == this.categoryId);

     this.searchForm.controls["subCategory"].setValue(this.subCategoryId); 
    });

    console.log("subcat=" + this._subCategories.length + "\n"+ "cat=" + this.categoryId + "\n" + "subcat=" + this.subCategoryId);
  }

 




  SearchByAscOrder() {
    this.ads = this.ads.sort((i, j) => i.price - j.price);
  }

  SearchByDescOrder() {
    this.ads = this.ads.sort((i, j) => j.price - i.price);
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
    this.searchService.result_Observer.subscribe(i => this.ads = i);
      // this.router.navigate(['/search', this.search, this.categoryId, this.subCategoryId, this.cityId]);
      this.location.replaceState('/search/' + this.search + '/' + this.categoryId + '/' + 
       this.subCategoryId + '/' + this.cityId);
    
  }

  // filterCity(val) {
  //   this.cityId = val;
  // }

  filterCategories() {
    // this.categoryId = val;
    this.subCategoryId = 0;
    this._subCategories = this.subCategories.filter(i => i.categoryId == this.categoryId);
  }

  // filterSubCategories(val) {
  //   this.subCategoryId = val;
  // }

  toTop(){
    window.scrollTo(0, 0);
 }
}