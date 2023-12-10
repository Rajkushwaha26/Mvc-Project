import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { NavBarComponent } from './FoodOrder/nav-bar/nav-bar.component';
import { HomeComponent } from './FoodOrder/home/home.component';
import { CartComponent } from './FoodOrder/cart/cart.component';
import { MenuComponent } from './FoodOrder/menu/menu.component';
import { PaymentComponent } from './FoodOrder/payment/payment.component';


const routes: Routes = [
  {path:'app-nav-bar',component:NavBarComponent},
  {path:'app-home',component:HomeComponent},
  {path:'app-cart',component:CartComponent},
  {path:'app-menu',component:MenuComponent},
  {path:'app-payment',component:PaymentComponent}

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
