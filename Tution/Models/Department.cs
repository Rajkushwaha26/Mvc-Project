using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tution.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime JoinDate { get; set; }
        public string Discrption { get; set; }
    }
}