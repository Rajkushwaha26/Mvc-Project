import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-test',
  template:`
  <h1>
    I Am From {{name}}
  </h1>
  <h3>{{2+2}}</h3>
  <h2>{{name}}<h2>
  <h3>{{name | lowercase}}</h3>
  <h3>{{name | uppercase}}</h3>
  <h2>{{mesaage | titlecase}}</h2>
  <h2>{{name | slice:3:7}}</h2>
  
 <h1>{{date | date:'shortDate'}}</
  
  

  
  
  
  `,
   // <input [id]="myId" type="text" value="Vishwas">
  // <input [disabled]="isDisabled" id="{{myId}}" type ="text" value="Vishwas">
  // <input #myInput type = "text">
  // <button (click)="logMessage(myInput.value)">Submit</button>
  styles:[]
})
export class TestComponent implements OnInit {

  public name="WelComeToIndia";
  public message ="Welcome to Codeworld";
  public myId = "testId";
  public isDisabled=false;

  constructor() { }

  ngOnInit() {
  }

  logMessage(value){
    console.log(value);
  }

}
