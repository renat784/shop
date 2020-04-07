import { Component } from '@angular/core';
import { Ads } from 'src/models/Ads';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent {
  ads: Ads[] = new Array();

  category_1: string[];
  
  constructor() {
    this.ads.push(
      { Id: 1, Image: '', Price: 100, Title: "item 1" },
      { Id: 2, Image: '', Price: 200, Title: "item 2" },
      { Id: 3, Image: '', Price: 300, Title: "item 3" },
      { Id: 4, Image: '', Price: 400, Title: "item 4" },
      { Id: 5, Image: '', Price: 500, Title: "item 5" },
      { Id: 6, Image: '', Price: 600, Title: "item 6" },
      { Id: 7, Image: '', Price: 700, Title: "item 7" },
      { Id: 8, Image: '', Price: 800, Title: "item 8" },
      { Id: 9, Image: '', Price: 900, Title: "item 9" }
    );

    this.category_1 = [
      "item 1",
      "item 2",
      "item 3",
      "item 4",
      "item 5",
      "item 6",
    ]

  }
}
