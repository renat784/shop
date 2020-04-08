import { CategoryPipe } from './../category.pipe';
import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent {
  public subCategories: SubCategory[] = [];
  public ads: Ad[] = [];

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {

    http.get<SubCategory[]>(baseUrl + 'categories').subscribe(result => {
      this.subCategories = result;
    }, error => console.error(error));

    http.get<Ad[]>(baseUrl + 'ads').subscribe(result => {
      this.ads = result;
    }, error => console.error(error));
    
  }

}

interface Ad {
  adId: number;
  title: string;
  price: number;
  desc: string;
  subCategoryId: number;
}

interface SubCategory {
  subCategoryId: number;
  name: string;
  categoryId: number;
}