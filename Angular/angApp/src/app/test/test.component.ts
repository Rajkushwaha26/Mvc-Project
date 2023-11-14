import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-test',
  template:`
  <h2>
    Welcome To {{name}}
  </h2>
  <h3>{{2+2}}</h3>
  
  <input [id]="myId" type="text" value="Vishwas">
  <input [disabled]="isDisabled" id="{{myId}}" type ="text" value="Vishwas">
  
  
  
  `,
  styles:[]
})
export class TestComponent implements OnInit {

  public name="India";

  public myId = "testId";
  public isDisabled=false;

  constructor() { }

  ngOnInit() {
  }

}
