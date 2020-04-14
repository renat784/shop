import { Router } from '@angular/router';
import { CategoryPipe } from './../category.pipe';
import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { SearchService } from '../search.service';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent {
  public subCategories: SubCategory[] = [];
  public ads: Ad[] = [];
  cities: City[] = [];
  cityId = 0;
  search = "all";
  categoryId = 0;
  subCategoryId = 0;
  categories: Category[];

  constructor(public http: HttpClient, @Inject('BASE_URL') public baseUrl: string, 
  public searchService: SearchService, public router :Router) {

    http.get<SubCategory[]>(baseUrl + 'categories/GetSubCategories').subscribe(result => {
      this.subCategories = result;
    }, error => console.error(error));

    http.get<Category[]>(baseUrl + 'categories/GetCategories').subscribe(result => {
      this.categories = result;
    }, error => console.error(error));

    http.get<Ad[]>(baseUrl + 'ads/GetTop25').subscribe(result => {
      this.ads = result;
    }, error => console.error(error));

    http.get<City[]>(baseUrl + 'city').subscribe(result => {
      this.cities = result;
    }, error => console.error(error));
    
  }

  ItemClicked(cat, subcat){
    this.categoryId = cat;
    this.subCategoryId = subcat;

    let filterUrl = this.baseUrl + 'ads/SearchByFilter/' +
    this.search + '/' +
    this.categoryId + '/' +
    this.subCategoryId + '/' +
    this.cityId + '/' + '-1/-1/1'; // no min price - no max price - sort by asc 

    this.searchService.findAds(filterUrl);

    this.router.navigate(['/search']);
  }

  onClickSubmit(form){
     if(form.search.length > 0 && form.search != " ") this.search = form.search;
     else this.search = "all";

     if(form.city != "") this.cityId = form.city;

     this.ItemClicked(this.categoryId, this.subCategoryId);
  }

}



