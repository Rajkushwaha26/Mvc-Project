import { Component, OnInit } from '@angular/core';
import { ActivatedRoute,Route, } from '@angular/router';

@Component({
  selector: 'DemoRoot',
  template: `<h1>Hello to Salonga</h1>`,
  styleUrls: ['./demo.component.css']
})
export class DemoRoot implements OnInit {

  constructor() { }

  ngOnInit() {
  }

}
