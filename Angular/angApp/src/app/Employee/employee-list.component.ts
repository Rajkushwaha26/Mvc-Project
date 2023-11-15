import {Component, OnInit}from '@angular/core';


@Component({
    selector:'employee-list',
    template:`
    <h2>Employee List</h2>
    <ul *ngFor="let employee of employees">
        <li>{{employee.name}}</li>
    </ul>
    `,
    styles:[]
})

export class EmployeeListComponent implements OnInit{
    
    public employees=[
        {"id":1, "name":"Raj","age":22},
        {"id":2,"name":"Ritu","age":21},
        {"id":3,"name":"Rohit","age":26}
    ];
    constructor(){}

    ngOnInit(){

    }
}