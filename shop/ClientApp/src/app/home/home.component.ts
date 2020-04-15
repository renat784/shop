import { DetailsService } from './../details.service';
import { DataService } from './../data.service';
import { Router } from '@angular/router';
import { Component, Inject } from '@angular/core';
import { SearchService } from '../search.service';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent {
  categories: Category[];
  subCategories: SubCategory[] = [];
  ads: Ad[] = [];
  cities: City[] = [];
  categoryId = 0;
  subCategoryId = 0;
  cityId = 0;
  search = "all";
  adsTotalCount = 0;
  innerHtml: string;
  categories_1: Category[] = [];
  categories_2: Category[] = [];
  categories_4: Category[] = [];
  categories_3: Category[] = [];
  styleCategory: StyleCategory[] = [];
  categoryArray_all: Category[][];
  shown_categoryId: number = 0;

  constructor(@Inject('BASE_URL') public baseUrl: string,
    public searchService: SearchService, public dataService: DataService, public router: Router,
     public detailsService:DetailsService) {

    dataService.findSubCategories().subscribe(i => this.subCategories = i);
    dataService.findCategories().subscribe(i => { this.categories = i; this.initCategoryArrays(); });
    dataService.findTopAds(25).subscribe(i => this.ads = i);
    dataService.findCities().subscribe(i => this.cities = i);
    dataService.adsTotalCount().subscribe(i => this.adsTotalCount = i);

    // icons and colors for each category
    this.styleCategory = [
      { categoryId: 1,  iconClass: 'fa fa-child',       color: '#e66a77' },
      { categoryId: 2,  iconClass: 'fa fa-home',        color: '#008fd3' },
      { categoryId: 3,  iconClass: 'fa fa-car',         color: '#e9810a' },
      { categoryId: 4,  iconClass: 'fa fa-cog',         color: '#569334' },
      { categoryId: 5,  iconClass: 'fa fa-briefcase',   color: '#a9b504' },
      { categoryId: 6,  iconClass: 'fa fa-paw',         color: '#84d0f0' },
      { categoryId: 7,  iconClass: 'fa fa-umbrella',    color: '#009896' },
      { categoryId: 8,  iconClass: 'fa fa-calculator',  color: '#00cc5e' },
      { categoryId: 9,  iconClass: 'fa fa-wrench',      color: '#1865b2' },
      { categoryId: 10, iconClass: 'fa fa-university',  color: '#86267e' },
      { categoryId: 11, iconClass: 'fa fa-bicycle',     color: '#bd6416' },
      { categoryId: 12, iconClass: 'fa fa-usd',         color: '#d20000' },
      { categoryId: 13, iconClass: 'fa fa-handshake-o', color: '#c9d72a' }
    ];
  }

  // creates 4 arrays because we have 4 rows with categories
  initCategoryArrays() {
   this.categoryArray_all = [this.categories_1, this.categories_2, this.categories_3, this.categories_4];

    for (let index = 0; index < this.categories.length; index++) {
      if (this.categories[index].categoryId == 1 ||
          this.categories[index].categoryId == 2 ||
          this.categories[index].categoryId == 3 ||
          this.categories[index].categoryId == 4) {
        this.categories_1.push(this.categories[index])
      }

      if (this.categories[index].categoryId == 5 ||
          this.categories[index].categoryId == 6 ||
          this.categories[index].categoryId == 7 ||
          this.categories[index].categoryId == 8) {
        this.categories_2.push(this.categories[index])
      }

      if (this.categories[index].categoryId == 9  ||
          this.categories[index].categoryId == 10 ||
          this.categories[index].categoryId == 11 ||
          this.categories[index].categoryId == 12) {
        this.categories_3.push(this.categories[index])
      }
      
      if (this.categories[index].categoryId == 13){
        this.categories_4.push(this.categories[index]);
      }
    }
  }

  // shows or hides items in category that was clicked
  ShowList(id){
    if(this.shown_categoryId == id) this.shown_categoryId = 0;
    else this.shown_categoryId = id;
  }

  ShowOrHide(id){
    if(id == this.shown_categoryId) return false;
    else return true;
  }

  // category or subcategory that was clicked
  ItemClicked(cat, subcat) {
    this.categoryId = cat;
    this.subCategoryId = subcat;

    let filterUrl = this.baseUrl + 'ads/SearchByFilter/' +
      this.search + '/' +
      this.categoryId + '/' +
      this.subCategoryId + '/' +
      this.cityId + '/' + '-1/-1/'; // no min price '-1' - no max price '-1'  

    this.searchService.findAds(filterUrl);
    this.router.navigate(['/search']);
  }

  onClickSubmit(form) {
    if (form.search.length > 0 && form.search != " ") this.search = form.search;
    else this.search = "all";
    
    this.ItemClicked(this.categoryId, this.subCategoryId);
  }

  // runs service to get data on Ad that was clicked
  // redirects to details page to see data
  Details(id){
    this.detailsService.getDetails(id);
    this.router.navigate(['/details']);
  }

  filterCity(val) {
    this.cityId = val;
  }

}