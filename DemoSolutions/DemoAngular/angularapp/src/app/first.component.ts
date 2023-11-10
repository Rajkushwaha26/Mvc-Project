import {Component} from "@angular/core";

@Component({
    selector:'first-component',
    templateUrl: './first.component.html'
})
export class FirstComponent
{
    //name:string[]=["Ragav","Rohan","Ritu","Rahul"]

    names:object[]=[
        {fname:'Raghav',lname:'Chohan',email:'A@gmail.com'},
        {fname:'Rohit',lname:'Pal',email:'Abjg@gmail.com'},
        {fname:'Raj',lname:'Kumar',email:'guguA@gmail.com'},
        {fname:'Ritu',lname:'Singh',email:'hA@gmail.com'}
    ]

    //doesExists=true;
    values="save";
    colorStyle:string = "color:blue;";
    greet:string= "Hello";
    twowayvariavle:string="Default value";

    save(event){
        console.log(event.target.value)
    }

}