import { HttpClient } from '@angular/common/http';
import { Component, OnInit, Inject } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';

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
  categoryId = 1;
  orderAsc = 1;
  priceMin = -1;
  priceMax = -1;
  filterUrl: string;



  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string, activatedRouter: ActivatedRoute, router: Router) {
    this.router = router;
    this.baseUrl = baseUrl;
    this.http = http;
    this.activatedRouter = activatedRouter;

    http.get<SubCategory[]>(baseUrl + 'Categories/GetSubCategories').subscribe(result => {
      this.subCategories = result;
      this._subCategories = result.filter(i => i.categoryId == this.categoryId);
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
    this.http.get<Ad[]>(this.filterUrl + '1').subscribe(result => {
      this.ads = result;
     
    }), error => console.error(error);
  }

  SearchByDescOrder() {
    this.http.get<Ad[]>(this.filterUrl + '0').subscribe(result => {
      this.ads = result;
   
    }), error => console.error(error);
  }

  onClickSubmit(formData) {

    if(formData.priceMin == null || formData.priceMin == undefined || formData.priceMin == '') this.priceMin = -1;
    else this.priceMin = formData.priceMin;

    if(formData.priceMax == null || formData.priceMax == undefined || formData.priceMax == '') this.priceMax = -1;
    else this.priceMax = formData.priceMax;

   

    this.filterUrl = this.baseUrl + 'ads/SearchByFilter/' +
      this.categoryId + '/' +
      this.subCategoryId + '/' +
      this.cityId + '/' +
      this.priceMin + '/' +
      this.priceMax + '/';

      console.log("min price=" + this.priceMin + "  \n" + "max price=" + this.priceMax );
    this.SearchByAscOrder();
  }

  filterCity(val) {
    this.cityId = val;
  }



  filterCategories(val) {
    this.categoryId = val;

    this._subCategories = this.subCategories.filter(i => i.categoryId == val);
  }

  filterSubCategories(val) {
    this.subCategoryId = val;
  }
}




