import { Component, OnInit } from '@angular/core';
import { MenuService } from 'src/app/Services/menu.service';

@Component({
  selector: 'app-menu',
  templateUrl: './menu.component.html',
  styleUrls: ['./menu.component.css']
})
export class MenuComponent implements OnInit {
  images:string[]=[];

  constructor(private fs:MenuService) { }

  ngOnInit():void {
    this.images=this.fs.getAllImage();
  }

}
