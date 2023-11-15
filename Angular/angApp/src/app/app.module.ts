import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { TestComponent } from './test/test.component';
import { EmployeeListComponent } from './Employee/employee-list.component';
import {  DemoRoot } from './demo/demo.component';


@NgModule({
  declarations: [
    AppComponent,
    TestComponent,
    EmployeeListComponent,
    DemoRoot
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
