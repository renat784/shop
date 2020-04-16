import { DataService } from './../data.service';
import { SearchService } from './../search.service';
import { HttpClient } from '@angular/common/http';
import { Component, Inject } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { DetailsService } from '../details.service';

@Component({
  selector: 'app-search',
  templateUrl: './search.component.html',
  styleUrls: ['./search.component.css']
})
export class SearchComponent {
  imageExample = "https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcQ-eXU7nuTNc2WpFt58LTyr7Cjx5hX_TfR09KFMDZu3dDbknnF6&usqp=CAU";
  // ads = { city: {} as City, category: {} as Category, subCategory: {} as SubCategory } as Ad;
  ads: Ad[] = [];
  router: Router;
  activatedRouter: ActivatedRoute;
  baseUrl: string;
  http: HttpClient;
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

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string, activatedRouter: ActivatedRoute, router: Router,
    public searchService: SearchService, public detailsService: DetailsService, public dataService: DataService) {

    searchService.result_Observer.subscribe(i => {
      if (i.length > 0) {
        this.ads = i;
      }
    })

    this.router = router;
    this.baseUrl = baseUrl;
    this.http = http;
    this.activatedRouter = activatedRouter;

    dataService.findSubCategories().subscribe(i => this.subCategories = i);

    if (this.categoryId != 0) {
      this._subCategories = this.subCategories.filter(i => i.categoryId == this.categoryId);
    } else this._subCategories = [];

    dataService.findCategories().subscribe(i => this.Categories = i);
    dataService.findCities().subscribe(i => this.cities = i);
  }

  SearchByAscOrder() {
    this.ads = this.ads.sort((i, j) => i.price - j.price);
  }

  SearchByDescOrder() {
    this.ads = this.ads.sort((i, j) => j.price - i.price);
  }

  Details(id) {
    this.detailsService.getDetails(id);
    this.router.navigate(['/details']);
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
  }

  filterCity(val) {
    this.cityId = val;
  }

  filterCategories(val) {
    this.categoryId = val;
    this.subCategoryId = 0;
    this._subCategories = this.subCategories.filter(i => i.categoryId == val);
  }

  filterSubCategories(val) {
    this.subCategoryId = val;
  }

 
}