using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace dotnetapp.Models
{
    public class AddressDetail
    {
        [Key]
        public int AddressId { get; set; }

        [ForeignKey("UserId")]
        public int UserId { get; set; }//FK
        public string Street { get; set; }
        public string City { get; set; }
        public string Pincode { get; set; }
    }
}