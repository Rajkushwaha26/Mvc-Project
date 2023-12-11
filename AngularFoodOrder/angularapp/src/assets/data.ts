import { Food } from "src/app/FoodOrder/Models/food";

export const sample_data:Food[]=[
    {
        id:1,
        price:50,
        name:'Piza Perrie',
        tags:['Fastfood','Pizza','Snack'],
        favorite:false,
        stars:4.5,
        imageurl:'/assets/images/p-1'

    },
    {
        id:1,
        price:100,
        name:'Piza Perrie',
        tags:['Fastfood','Pizza','Snack'],
        favorite:false,
        stars:4.5,
        imageurl:'/assets/images/p-1'

    },
    {
        id:2,
        price:50,
        name:'Ice Cream',
        tags:['Icrecream','Cream','Sweet'],
        favorite:true,
        stars:5,
        imageurl:'/assets/images/p-2'

    },
    {
        id:3,
        price:50,
        name:'Bugger',
        tags:['Fastfood','Bugger','Snack'],
        favorite:false,
        stars:4.5,
        imageurl:'/assets/images/p-3'

    }
]