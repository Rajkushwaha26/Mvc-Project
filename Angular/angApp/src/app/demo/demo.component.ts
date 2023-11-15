import { Component, OnInit } from '@angular/core';
import { ActivatedRoute,Route,Params } from '@angular/router';

@Component({
  selector: 'DemoRoot',
  template: `<h1>Hello to Salonga</h1>`,
  styleUrls: ['./demo.component.css']
})
export class DemoRoot  {

  constructor(private activateRoute:ActivatedRoute) {
    console.log(activateRoute.snapshot.paramMap.get('id'));
   }


  ngOnDestory() {
    console.log("Destroy")
  };

}
