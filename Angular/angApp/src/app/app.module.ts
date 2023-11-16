import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { TestComponent } from './test/test.component';
import { EmployeeListComponent } from './Employee/employee-list.component';
import {  DemoRoot } from './demo/demo.component';
import {  HelloworldService } from './service-utilies/helloworld.service';
import {Guard} from './routerGuard.service';
//import {TokenDemo} from './tokenatziation.component';
import { Life } from './lifecycle.component';

@NgModule({
  declarations: [
    AppComponent,
    TestComponent,
    EmployeeListComponent,
    DemoRoot,
    // TokenDemo,
    Life
  
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    
  ],
  providers: [HelloworldService, Guard],
  bootstrap: [AppComponent]
})
export class AppModule { }
