import { Router } from '@angular/router';
import { SearchService } from './../search.service';
import { DataService } from './../data.service';
import { Component, OnInit, Inject } from '@angular/core';

@Component({
  selector: 'app-footer',
  templateUrl: './footer.component.html',
  styleUrls: ['./footer.component.css']
})
export class FooterComponent implements OnInit {
  categories: Category[] = [];
  logoFooter = "https://static-olxeu.akamaized.net/static/olxua/packed/font/2ff1f8736a27eb257f9688cf3b21332f49.svg";
  facebookLogo = "https://static-olxeu.akamaized.net/static/olxua/packed/font/2f8beb30d7b5a18302412e315921d6ce6d.svg";
  youtubeLogo = "https://static-olxeu.akamaized.net/static/olxua/packed/font/2f50fd81b399890d1544c4fad903220963.svg";
  twitterLogo = "https://static-olxeu.akamaized.net/static/olxua/packed/font/2f5539ffc137444af4f407f5f6f7e43e9b.svg";
  weOnFacebook = "https://lh5.googleusercontent.com/proxy/dTlbDY8ljv21aw0fesL7PG-ydqm5hS3nvaLDZqAhFOVcFaNcWverzz0aKtV6HOAoLcxxwzfDA1ki6klkjZfxzAl3XBjyoFGNtQ";

  constructor(@Inject('BASE_URL') public baseUrl: string, public dataService: DataService, 
  public searchService: SearchService, public router: Router) { 
    dataService.findCategories().subscribe(i => this.categories = i);
  }

  ItemClicked(id){
    let filterUrl = this.baseUrl + 'ads/SearchByFilter/all/' + id + '/0/0/-1/-1/';
    this.searchService.findAds(filterUrl);
    this.router.navigate(['/search']);
  }

  ngOnInit() {
  }

}
