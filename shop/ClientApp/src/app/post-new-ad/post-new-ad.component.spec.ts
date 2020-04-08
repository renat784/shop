import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { PostNewAdComponent } from './post-new-ad.component';

describe('PostNewAdComponent', () => {
  let component: PostNewAdComponent;
  let fixture: ComponentFixture<PostNewAdComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ PostNewAdComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(PostNewAdComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
