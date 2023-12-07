using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnetapp.Models
{
    public class Payment
    {
        public int PaymentId { get; set; }
        public int OrderId { get; set; }
        public Date PaymentDate { get; set; }
        public string Amount { get; set; }
        public string PaymentMethod { get; set; }
    }
}