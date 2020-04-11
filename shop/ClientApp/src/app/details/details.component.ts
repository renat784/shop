import { Component, Inject, OnInit } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-details',
  templateUrl: './details.component.html',
  styleUrls: ['./details.component.css']
})
export class DetailsComponent {
   ad = {city:{} as City, category:{} as Category, subCategory:{} as SubCategory} as Ad;


constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string, private router: ActivatedRoute) {
    let id = this.router.snapshot.queryParamMap.get('id');
    http.get<Ad>(baseUrl + 'ads/SearchByAdId/' + id).subscribe(result => {
      this.ad = result;
      console.log(this.ad);
    }, error => console.error(error));
  }
}



