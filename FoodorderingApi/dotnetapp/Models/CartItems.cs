using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnetapp.Models
{
    public class CartItems
    {
        public int CartItemId { get; set; }
        public int UserId { get; set; }//FK
        public int MenuItemId { get; set; }//FK
        public int Quantity { get; set; }
    }
}