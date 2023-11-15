import { Component, NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { DemoRoot } from './demo/demo.component';
import {TestComponent} from './test/test.component';
import {sorry} from '/sorry.component';


const routes: Routes = [{path:'',component:DemoRoot},
{path:'form/:id',component:TestComponent},
{path:'**', component:sorry}];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
