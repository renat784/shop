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
  // strings under get app for your phone
  showGetApp = true;
  showGetGoogleApp = false;
  showGetAppleApp = false;


  constructor(@Inject('BASE_URL') public baseUrl: string, public dataService: DataService, public searchService: SearchService, public router: Router) {
    
  }

  ngOnInit() {
  }

  ShowGetApp(){
    this.showGetApp = true;
    this.showGetAppleApp = false;
    this.showGetGoogleApp = false;
  }

  ShowOne(val){
    if(val == 'google'){
      this.showGetGoogleApp = true;
      this.showGetApp = false;
      this.showGetAppleApp = false;
    }
    else{
      this.showGetAppleApp = true;
      this.showGetApp = false;
      this.showGetGoogleApp = false;
    }
  }
 
}
