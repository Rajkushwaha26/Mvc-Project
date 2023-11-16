import { Component, SimpleChange, SimpleChanges} from "@angular/core";
import {Router,ActivatedRoute, Params} from '@angular/router';

@Component({
    selector:'life',
    template:`<input type="text" [(ngModel)]="text"> {{text}}
               <first-component></first-component>`
})
export class Life
{

    text:string=" ";

 constructor(private routerActivated:ActivatedRoute){
   let res:string = this.routerActivated.snapshot.paramMap.get('id');
  console.log(res);
  console.log("constructor");
 }
 ngOnChanges(change:SimpleChanges){
    console.log("ngOnChange");
 }
 ngOnInit(){
    console.log("ngOnInit")
 }
 ngDoCheck(){
    console.log("ngDoCheck")
 }
 ngAfterContentInit(){
    console.log("ngAfterContentInit")
 }
 ngAfterContentCheck(){
    console.log("ngAfterContentCheck")
 }
 ngAfterViewInit(){
    console.log("ngAfterViewInit")
 }
 NgAfterViewCheck(){
    console.log("NgAfterViewCheck")
 }
 ngOnDestroy(){
    console.log("ngOnDestroy")
 }
}