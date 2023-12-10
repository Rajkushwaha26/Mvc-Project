import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HomeComponent } from './FoodOrder/home/home.component';
import { MenuComponent } from './FoodOrder/menu/menu.component';
import { CartComponent } from './FoodOrder/cart/cart.component';
import { PaymentComponent } from './FoodOrder/payment/payment.component';
import {HttpClient, HttpClientModule} from '@angular/common/http';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { NavBarComponent } from './FoodOrder/nav-bar/nav-bar.component';
import { ReviesComponent } from './FoodOrder/revies/revies.component';

@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    MenuComponent,
    CartComponent,
    PaymentComponent,
    NavBarComponent,
    ReviesComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    FormsModule,
    ReactiveFormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
