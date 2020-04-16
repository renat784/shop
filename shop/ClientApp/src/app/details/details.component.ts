import { DetailsService } from './../details.service';
import { Component } from '@angular/core';

@Component({
  selector: 'app-details',
  templateUrl: './details.component.html',
  styleUrls: ['./details.component.css']
})
export class DetailsComponent {
  exampleImage = "https://apollo-ireland.akamaized.net/v1/files/p6kjfl9l3ooz1-UA/image;s=644x461";
  ad = { city: {} as City, category: {} as Category, subCategory: {} as SubCategory } as Ad;
  

  constructor(public detailsService: DetailsService) {
    detailsService.ad_Details.subscribe(i => this.ad = i);
  }
}