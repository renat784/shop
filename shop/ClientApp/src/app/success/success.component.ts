import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-success',
  templateUrl: './success.component.html',
  styleUrls: ['./success.component.css']
})
export class SuccessComponent implements OnInit {
  public Adid;

  constructor(private route: ActivatedRoute) {
    this.Adid = this.route.snapshot.params.id;
   }

  ngOnInit() {
  }

}
