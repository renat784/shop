import { DetailsService } from './../details.service';
import { Component } from '@angular/core';

@Component({
  selector: 'app-details',
  templateUrl: './details.component.html',
  styleUrls: ['./details.component.css']
})
export class DetailsComponent {
  // ad = { city: {} as City, category: {} as Category, subCategory: {} as SubCategory } as Ad;
  ad: Ad = {} as Ad;

  constructor(public detailsService: DetailsService) {
    detailsService.ad_Details.subscribe(i => this.ad = i);
  }
}