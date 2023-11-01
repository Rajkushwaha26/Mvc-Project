using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BLood.Models
{
    public class BloodDonor
    {
        public int ID { get; set; } 
        public string? Name { get; set; }
        public int Age { get; set; }
        public string? BloodGroup { get; set; }
        public DateTime DOB { get; set; }
    }
}