import { Injectable, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class DataService {

  constructor(public http: HttpClient, @Inject('BASE_URL') public baseUrl: string) { }

  findCities() {
    return this.http.get<City[]>(this.baseUrl + 'city');
  }

  findTopAds(count) {
    return this.http.get<Ad[]>(this.baseUrl + 'ads/GetTop/' + count);
  }

  adsTotalCount() {
    return this.http.get<number>(this.baseUrl + 'ads/AdsTotalCount');
  }

  findCategories() {
    return this.http.get<Category[]>(this.baseUrl + 'categories/GetCategories');
  }

  findSubCategories() {
    return this.http.get<SubCategory[]>(this.baseUrl + 'categories/GetSubCategories');
  }

}
