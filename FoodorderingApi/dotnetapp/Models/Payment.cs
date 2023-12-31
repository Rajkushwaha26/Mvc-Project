using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace dotnetapp.Models
{
    public class Payment
    {
        [Key]
        public int PaymentId { get; set; }

        [ForeignKey("OrderId")]
        public int OrderId { get; set; }//FK
        public DateTime PaymentDate { get; set; }
        public string Amount { get; set; }
        public string PaymentMethod { get; set; }
    }
}