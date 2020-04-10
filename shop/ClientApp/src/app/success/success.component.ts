import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-success',
  templateUrl: './success.component.html',
  styleUrls: ['./success.component.css']
})
export class SuccessComponent implements OnInit {
  public Adid;

  constructor(private router: ActivatedRoute) {
     this.Adid = this.router.snapshot.queryParamMap.get('AdId');
     console.log(this.Adid);
   }

  ngOnInit() {
  }

}
