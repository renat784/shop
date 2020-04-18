import { DetailsService } from './../details.service';
import { Component } from '@angular/core';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-details',
  templateUrl: './details.component.html',
  styleUrls: ['./details.component.css']
})
export class DetailsComponent {
  exampleImage = "https://apollo-ireland.akamaized.net/v1/files/p6kjfl9l3ooz1-UA/image;s=644x461";
  exampleProfileImage = "https://img01-olxua.akamaized.net/img-olxua/530374236_1_261x203_rev001.jpg";
  ad = { city: {} as City, category: {} as Category, subCategory: {} as SubCategory } as Ad;

  constructor(public detailsService: DetailsService, public route: ActivatedRoute) {
    let id = this.route.snapshot.params.id;
    detailsService.getDetails(id).subscribe(i => this.ad = i);
  }
}