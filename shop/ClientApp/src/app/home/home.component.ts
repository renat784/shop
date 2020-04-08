import { CategoryPipe } from './../category.pipe';
import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent {
  public subCategories: SubCategory[];

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {

    http.get<SubCategory[]>(baseUrl + 'categories').subscribe(result => {
      this.subCategories = result;
    }, error => console.error(error), () => console.log(this.subCategories));

    
  }

}

interface SubCategory {
  subCategoryId: number;
  name: string;
  categoryId: number;
}