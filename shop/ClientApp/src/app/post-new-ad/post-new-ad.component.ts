import { DetailsService } from './../details.service';
import { DataService } from './../data.service';
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
  cityId = 0;
  subCategories: SubCategory[] = [];
  _subCategories: SubCategory[] = [];
  subCategoryId = 0;
  Categories: Category[] = [];
  categoryId = 0;
  categoryChanged: boolean;

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string, private router: Router, public dataService: DataService, public detailsService: DetailsService) {
    
    this.client = http;
    this.baseUrl = baseUrl;
    dataService.findSubCategories().subscribe(i => this.subCategories = i);

    if (this.categoryId != 0) {
      this._subCategories = this.subCategories.filter(i => i.categoryId == this.categoryId);
    } else this._subCategories = [];

    dataService.findCategories().subscribe(i => this.Categories = i);
    dataService.findCities().subscribe(i => this.cities = i);
  }

  onClickSubmit(formData) {
    this.data =
    {
      Title: formData.title,
      Price: formData.price,
      Desc: formData.desc,
      CategoryId: this.ToNumber(this.categoryId),
      SubCategoryId: this.ToNumber(this.subCategoryId),
      CityId: this.ToNumber(this.cityId),
      Phone: formData.phone,
      Email: formData.email,
      ContactPerson: formData.contactPerson
    };

    console.log(this.data);

    this.client.post(this.baseUrl + 'ads', this.data).subscribe(
      (response) => {
        let added_Id = response;
        this.detailsService.getDetails(added_Id);
        this.router.navigate(['/success', added_Id]);
      });
  }

  ngOnInit() { }

  filterCity(val) {
    this.cityId = val;
  }

  ToNumber(val) {
    let new_value = parseInt(val);
    return new_value;
  }

  filterCategories(val) {
    this.categoryChanged = true;
    this.categoryId = val;
    this.subCategoryId = 0;
    console.log("CategoryId=" + this.categoryId + "  subcategoryid=" + this.subCategoryId);
    this._subCategories = this.subCategories.filter(i => i.categoryId == val);
  }

  filterSubCategories(val) {
    this.categoryChanged = false;
    this.subCategoryId = val;
    console.log("CategoryId=" + this.categoryId + "  subcategoryid=" + this.subCategoryId);
  }
}