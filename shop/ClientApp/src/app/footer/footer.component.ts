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
