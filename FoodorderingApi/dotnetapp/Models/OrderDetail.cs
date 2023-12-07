using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnetapp.Models
{
    public class OrderDetail
    {
        public int OrderId { get; set; }
        public int UserId { get; set; }//FK
        public Date OrderDate { get; set; }
        public int TotalAmount { get; set; }
    }
}