import { Injectable, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class DataService {

  constructor(public http: HttpClient, @Inject('BASE_URL') public baseUrl: string) { }

  findTopAds(count) {
    return this.http.get<Ad[]>(this.baseUrl + 'ads/getTop/' + count);
  }

  adsTotalCount() {
    return this.http.get<number>(this.baseUrl + 'ads/adsTotalCount');
  }

  findCategories() {
    return this.http.get<Category[]>(this.baseUrl + 'data/categories');
  }

  findSubCategories() {
    return this.http.get<SubCategory[]>(this.baseUrl + 'data/subCategories');
  }

  findCities() {
    return this.http.get<City[]>(this.baseUrl + 'data/cities');
  }

}
