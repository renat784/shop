import { HttpClient } from '@angular/common/http';
import { Component, OnInit, Inject } from '@angular/core';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-search',
  templateUrl: './search.component.html',
  styleUrls: ['./search.component.css']
})
export class SearchComponent {
  ads: Ad[] = [];
  
  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string, private router: ActivatedRoute) {

    if (this.router.snapshot.queryParamMap.get('subCategoryId') != null) {
      let id = this.router.snapshot.queryParamMap.get('subCategoryId');

      http.get<Ad[]>(baseUrl + 'ads/SearchBySubCategoryId/' + id).subscribe(result => {
        this.ads = result;
      }, error => console.error(error));
    }

    else if (this.router.snapshot.queryParamMap.get('CategoryId') != null) {
      let id = this.router.snapshot.queryParamMap.get('CategoryId');

      http.get<Ad[]>(baseUrl + 'ads/SearchByCategoryId/' + id).subscribe(result => {
        this.ads = result;
      }, error => console.error(error));
    }




  }
}



interface Ad {
  adId: number;
  title: string;
  price: number;
  desc: string;
  subCategoryId: number;
}
