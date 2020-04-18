import { Observable } from 'rxjs';
import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class SearchService {
  private http: HttpClient;
  private ads: Ad[] = [];
  public result_Observer = new Observable<Ad[]>();

  constructor(http: HttpClient) {
    this.http = http;
  }

  findAds(filterUrl: string, asc = true) {
    if (asc) {
      filterUrl += 1;
    }
    else {
      filterUrl += 0;
    }

    console.log("service search: get=" + filterUrl);
    this.result_Observer = this.http.get<Ad[]>(filterUrl);
  }
}




