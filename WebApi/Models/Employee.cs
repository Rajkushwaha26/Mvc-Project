using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public int Salary { get; set; }
        public int DesignationId { get; set; }
        public int DepartmentId { get; set; }
        public Department? Department{get;set;}
        public Designation? Designation{get;set;}

    }
}