using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tution.Models
{
    public class Book
    {
        public int EmloyeeID { get; set; }
        public string EmployeeName { get; set; }
        public int DepartmentId{ get; set; }
        public string Salary { get; set; }
        public DateTime JoinDate { get; set; }
        public virtual Department? Department {get;set;}
    }
}