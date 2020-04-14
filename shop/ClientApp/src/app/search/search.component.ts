import { SearchService } from './../search.service';
import { HttpClient } from '@angular/common/http';
import { Component, OnInit, Inject } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { stringify } from 'querystring';
import { InstantSearchService } from '../instant-search.service';

@Component({
  selector: 'app-search',
  templateUrl: './search.component.html',
  styleUrls: ['./search.component.css']
})
export class SearchComponent {
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
    public searchService: SearchService) {

    searchService.result_Observer.subscribe(i => {
      if(i.length > 0){
        this.ads = i;
      }
    })

    this.router = router;
    this.baseUrl = baseUrl;
    this.http = http;
    this.activatedRouter = activatedRouter;

    http.get<SubCategory[]>(baseUrl + 'Categories/GetSubCategories').subscribe(result => {
      this.subCategories = result;
      if (this.categoryId != 0) {
        this._subCategories = result.filter(i => i.categoryId == this.categoryId);
      } else this._subCategories = [];

    }, error => console.error(error));

    http.get<Category[]>(baseUrl + 'Categories/GetCategories').subscribe(result => {
      this.Categories = result;
    }, error => console.error(error));

    http.get<City[]>(baseUrl + 'city').subscribe(result => {
      this.cities = result;
    }, error => console.error(error));


    if (this.activatedRouter.snapshot.queryParamMap.get('subCategoryId') != null) {
      let id = this.activatedRouter.snapshot.queryParamMap.get('subCategoryId');

      this.http.get<Ad[]>(baseUrl + 'ads/SearchBySubCategoryId/' + id).subscribe(result => {
        this.ads = result;
      }, error => console.error(error));
    }

    else if (this.activatedRouter.snapshot.queryParamMap.get('categoryId') != null) {
      let id = this.activatedRouter.snapshot.queryParamMap.get('categoryId');

      this.http.get<Ad[]>(baseUrl + 'ads/SearchByCategoryId/' + id).subscribe(result => {
        this.ads = result;
      }, error => console.error(error));
    }




  }

  SearchByAscOrder() {
    this.ads = this.ads.sort((i,j) => i.price - j.price);
    
  }

  SearchByDescOrder() {
    this.ads = this.ads.sort((i,j) => j.price - i.price);
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




