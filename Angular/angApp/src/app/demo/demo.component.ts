import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { ActivatedRoute,Route,Params, Router } from '@angular/router';

@Component({
  selector: 'DemoRoot',
  template: `<h1>Hello to Salonga</h1><button type="button" (click)="handleRoute()">Navigate</button>`
  
})
export class DemoRoot  {

  constructor(private route:Router) {
    //console.log(activateRoute.snapshot.paramMap.get('id'));
   }
  // handleRoute(){
  //   this.route.navigate(["/form",23])
  // }

  ngOnDestory() {
    console.log("Destroy");
  }

 

}
