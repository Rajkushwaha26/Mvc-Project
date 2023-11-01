using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FamilyApp.Models
{
    public class Detail
    {
        public int FamilyId { get; set; }
        public string? Name { get; set; }
        public int? Age  { get; set; }

        public string? Address {get;set;}
    }
}