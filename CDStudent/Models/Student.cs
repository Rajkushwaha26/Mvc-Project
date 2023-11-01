using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CDStudent.Models
{
    public class Student
    {
        public int Id {get;set;}
        public string? Name { get; set; }
        public string? Address { get; set; }
        public int? PhoneNo {get;set;}
        public DateTime? JoinDate {get;set;}
    }
}