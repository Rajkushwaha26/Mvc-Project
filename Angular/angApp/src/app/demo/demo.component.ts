import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { ActivatedRoute,Route,Params, Router } from '@angular/router';
import { HelloworldService } from '../service-utilies/helloworld.service';

@Component({
  selector: 'DemoRoot',
 //template: `<h1>Hello to Salonga</h1><button type="button" (click)="handleRoute()">Navigate</button>`,
  templateUrl:'./test/test.component.html'
  
  
})
export class DemoRoot  {

  constructor(private route:Router, private hello:HelloworldService) {
    //console.log(activateRoute.snapshot.paramMap.get('id'));
   }
  handleRoute(){
    this.route.navigate(["/form",23])
  }

 

 

}
