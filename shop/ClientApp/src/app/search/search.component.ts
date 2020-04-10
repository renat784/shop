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
  summaries: string[] = ["Kiev", "Kharkov", "Lviv"];
  city = "Вся Украина";
  subCategories: SubCategory[] = [];
  subCategoryId = 0;

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string, activatedRouter: ActivatedRoute, router: Router) {
    this.router = router;
    this.baseUrl = baseUrl;
    this.http = http;
    this.activatedRouter = activatedRouter;
    
    http.get<SubCategory[]>(baseUrl + 'categories').subscribe(result => {
      this.subCategories = result;
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

  onClickSubmit(formData) {

    if(this.subCategoryId != 0){
      this.http.get<Ad[]>(this.baseUrl + 'ads/SearchBySubCategoryId/' +  this.subCategoryId).subscribe(result => {
        if (this.city != "Вся Украина") {
          this.ads = result.filter(i => i.city == this.city);
        } else {
          this.ads = result;
        }
      }, error => console.error(error));
    }
    else{
      this.http.get<Ad[]>(this.baseUrl + 'ads/SearchAll/').subscribe(result => {
        if (this.city != "Вся Украина") {
          this.ads = result.filter(i => i.city == this.city);
        } else {
          this.ads = result;
        }
      }, error => console.error(error));
    }
    
  }

  filterForeCasts(val){
    this.city = val;
  }

  filterCategories(val){
    this.subCategoryId = val;
  }

}




