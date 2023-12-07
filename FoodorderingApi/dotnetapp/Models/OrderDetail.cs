using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace dotnetapp.Models
{
    public class OrderDetail
    {
        public int OrderId { get; set; }

        [ForeignKey("UserId")]
        public int UserId { get; set; }//FK
        public date OrderDate { get; set; }
        public int TotalAmount { get; set; }
    }
}