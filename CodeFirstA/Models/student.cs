using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CodeFirstA.Models
{
    public class student
    {
       
        public int Id {get;set;}
        public string Name { get; set; }
        public String Gender  { get; set; }
        public int Age { get; set; }
    }
}