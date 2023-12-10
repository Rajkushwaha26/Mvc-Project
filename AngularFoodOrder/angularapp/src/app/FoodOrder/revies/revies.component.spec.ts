import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ReviesComponent } from './revies.component';

describe('ReviesComponent', () => {
  let component: ReviesComponent;
  let fixture: ComponentFixture<ReviesComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ReviesComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ReviesComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
