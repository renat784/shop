import { Observable } from 'rxjs';
import { Injectable, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class DetailsService {
public ad_Details : Observable<Ad>;
  constructor(public http: HttpClient, @Inject('BASE_URL') public baseUrl: string) { }

  getDetails(id){
    this.ad_Details = this.http.get<Ad>(this.baseUrl + 'ads/SearchByAdId/' + id);
      
  }
}
