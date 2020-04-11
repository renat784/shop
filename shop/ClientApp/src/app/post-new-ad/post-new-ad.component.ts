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
  subCategoryId = 1;

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string, private router: Router) {
    this.client = http;
    this.baseUrl = baseUrl;

    http.get<SubCategory[]>(baseUrl + 'categories').subscribe(result => {
      this.subCategories = result;
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
      CategoryId: 1,
      SubCategoryId: this.subCategoryId,
      CityId: this.cityId,
      Phone: formData.phone,
      Email: formData.email,
      ContactPerson: formData.contactPerson
    };

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

  filterCategories(val){
    this.subCategoryId = val;
  }
}