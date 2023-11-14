import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-test',
  template:`
  <h2>
    Welcome{{name}}
  </h2>
  <h3>{{2+2}}</h3>
  <h2>{{{name.toUpperCase()}}</h2>`,
  styles:[]
})
export class TestComponent implements OnInit {

  constructor() { }

  ngOnInit() {
  }

}
