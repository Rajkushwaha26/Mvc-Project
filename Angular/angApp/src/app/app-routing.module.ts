import { Component, NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { DemoRoot } from './demo/demo.component';



const routes: Routes = [{path:'',component:DemoRoot},
{path:'form',:test}];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
