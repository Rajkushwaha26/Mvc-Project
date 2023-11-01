using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Realme.Data
{
    public class Employee
    {
        public int EmployeeId {set; get;} = 0;
        public string? EmployeeName {set; get;}
        public int DepartmentId {set; get;}
        public decimal Salary {set; get;}
        public DateTime JoinDate {set; get;}
        public virtual Department? Department {set; get;}
    }
}