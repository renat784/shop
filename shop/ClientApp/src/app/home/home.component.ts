import { Component } from '@angular/core';
import { Ads } from 'src/models/Ads';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent {
  ads: Ads[] = new Array();

  /**
   *
   */
  constructor() {
    this.ads.push(
      { Price: 100, Title: "item 1" },
      { Price: 200, Title: "item 2" },
      { Price: 300, Title: "item 3" },
      { Price: 400, Title: "item 4" },
      { Price: 500, Title: "item 5" },
      { Price: 600, Title: "item 6" },
      { Price: 700, Title: "item 7" },
      { Price: 800, Title: "item 8" },
      { Price: 900, Title: "item 9" }
    )

  }
}
