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
  public data = {};
  client: HttpClient;
  baseUrl: string;

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string, private router: Router) {
    this.client = http;
    this.baseUrl = baseUrl;
  }

   onClickSubmit(formData) {
    this.data =
    {
      Title: formData.title,
      Price: formData.price,
      Desc: formData.desc,
      SubCategoryId: 2,
      CategoryId: 1,
      City: formData.city,
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
}