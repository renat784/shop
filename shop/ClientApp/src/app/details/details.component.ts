import { DetailsService } from './../details.service';
import { Component } from '@angular/core';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-details',
  templateUrl: './details.component.html',
  styleUrls: ['./details.component.css']
})
export class DetailsComponent {
  ad = { city: {} as City, category: {} as Category, subCategory: {} as SubCategory } as Ad;

  constructor(public detailsService: DetailsService, public route: ActivatedRoute) {
    let id = this.route.snapshot.params.id;
    detailsService.getDetails(id).subscribe(i => this.ad = i);
  }
}