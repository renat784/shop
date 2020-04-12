import { Component, OnInit, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { ActivatedRoute, Router } from '@angular/router';
import { Validators } from '@angular/forms';


@Component({
  selector: 'app-post-new-ad',
  templateUrl: './post-new-ad.component.html',
  styleUrls: ['./post-new-ad.component.css']
})
export class PostNewAdComponent implements OnInit {
  data = {};
  client: HttpClient;
  baseUrl: string;
  cities: City[] = [];
  cityId = 1;
  subCategories: SubCategory[] = [];
  _subCategories: SubCategory[] = [];
  subCategoryId = 1;
  Categories: Category[] = [];
  categoryId = 1;

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string, private router: Router) {
    this.client = http;
    this.baseUrl = baseUrl;

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
  }

   onClickSubmit(formData) {
    this.data =
    {
      Title: formData.title,
      Price: formData.price ,
      Desc: formData.desc,
      CategoryId: this.ToNumber(this.categoryId),
      SubCategoryId: this.ToNumber(this.subCategoryId),
      CityId:  this.ToNumber(this.cityId),
      Phone: formData.phone,
      Email: formData.email,
      ContactPerson: formData.contactPerson
    };

    console.log(this.data);

    this.client.post(this.baseUrl + 'ads', this.data).subscribe(
      (response) => {
        
        let added_Id = response;
        this.router.navigate(['success'], { queryParams: { AdId: added_Id } } );
      });
  }

 

  ngOnInit() { }

  filterCity(val){
    this.cityId = val;
  }

  ToNumber(val){
    let new_value = parseInt(val);
    return new_value;
  }

  filterCategories(val){
    this.categoryId = val;
    console.log("CategoryId=" + this.categoryId + "  subcategoryid=" + this.subCategoryId);
    this._subCategories = this.subCategories.filter(i => i.categoryId == val);
  }

  filterSubCategories(val){
    this.subCategoryId = val;
    console.log("CategoryId=" + this.categoryId + "  subcategoryid=" + this.subCategoryId);
  }
}