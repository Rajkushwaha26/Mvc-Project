// // import {Component} from "@angular/core";
// // import {HttpClient, HttpHeaders} from "@angular/common/http";
// // import { error } from "console";

// // @Component({
// //     selector:'token-demo',
// //     template:`<h1>Token Demo</h1>`
// // })

// // export class TokenDemo
// // {
// //     _token:any="";

// //     constructor(private http:HttpClient)
// //     {
// //         let httpheaders:HttpHeaders = new HttpHeaders
// //         ({
// //             Accept:'application/json'
// //         });
// //         this.http.post<Idata>("https://8080-cfdbdbcbdfabcaaaceeafebeccaddbefddaf.premiumproject.examly.io/api/StudentApi",
// //         {name:'user1',password:'password'},
// //         {headers:httpheaders})
// //         .subscribe(token=>
// //             {console.log(token); this._token=token},
// //             error=>{
// //                 console.log(error);
// //             })

// //             save()
// //             {
// //                 let authhttpheaders : HttpHeaders = new HttpHeaders({
// //                     Accept:'application/json',
// //                     Authorization: 'Bearer ${this._token}' 
// //                 })
// //                 this.http.put("https://8080-cafbdfcedbbcdfabcaaaceeafebeccaddbefddaf.premiumproject.examly.io/WeatherForecast/auth", {}, {headers:authhttpheaders});
// //             }
        
// //         }
        
        

// //     }
// // }

// // interface Idata{
// //     name:string
// //     password:string
// // }

// import { Component } from "@angular/core";
// import {HttpClient, HttpHandler, HttpHeaders} from "@angular/common/http";

// @Component({
//     selector:'token-demo',
//     template:'<h1>Token Demo</h1> <button type="button" (click)="save()">Save</button>'
// })

// export class TokenDemo {

//     _token:any = ""

//     constructor(private http:HttpClient){
//         let httpheaders:HttpHeaders = new HttpHeaders({
//             Accept:'application/json'
//         });
//         this.http.post<Idata>("https://8080-cafbdfcedbbcdfabcaaaceeafebeccaddbefddaf.premiumproject.examly.io/WeatherForecast/auth", 
//         {username:'username', password:'password'}, 
//         {headers:httpheaders})
//         .subscribe(token => 
//             {
//                 {console.log(token), this._token = token};
//             },
//             error => {
//                 console.log(error);
//             })
//     }

//     save()
//     {
//         let authhttpheaders : HttpHeaders = new HttpHeaders({
//             Accept:'application/json',
//             Authorization: 'Bearer ${this._token}' 
//         })
//         this.http.put("https://8080-cafbdfcedbbcdfabcaaaceeafebeccaddbefddaf.premiumproject.examly.io/WeatherForecast/auth", {}, {headers:authhttpheaders});
//     }

// }

// interface Idata {
//     user:string
//     password:string
// }