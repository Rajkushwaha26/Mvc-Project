import { Component, OnInit } from '@angular/core';
import { Food } from '../Models/food';
import { HomeService } from 'src/app/Services/home.service';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {
  foods:Food[]=[];
  constructor(private U:HomeService) {
    this.foods=U.getAll()
   }

  ngOnInit() {
  }

}
