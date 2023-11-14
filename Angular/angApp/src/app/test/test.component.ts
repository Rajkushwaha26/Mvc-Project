import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-test',
  template:`
  <h2>
  Welcome{{name}}`
  styleUrls: ['./test.component.css']
})
export class TestComponent implements OnInit {

  constructor() { }

  ngOnInit() {
  }

}
