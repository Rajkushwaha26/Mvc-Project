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
        [Key]
        public int CartItemId { get; set; }

        [ForeignKey("UserId")]
        public int UserId { get; set; }//FK

        [ForeignKey("MenuId")]
        public int MenuId { get; set; }//FK
        public int Quantity { get; set; }
    }
}