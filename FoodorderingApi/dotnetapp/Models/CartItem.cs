using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace dotnetapp.Models
{
    public class CartItem
    {
        public int CartItemId { get; set; }

        [ForeignKey("UserId")]
        public int UserId { get; set; }//FK

        [ForeignKey("MenuItemId")]
        public int MenuItemId { get; set; }//FK
        public int Quantity { get; set; }
    }
}