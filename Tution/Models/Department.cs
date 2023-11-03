using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tution.Models
{
    public class Course
    {
        public int DepartmentIdId { get; set; }
        public string DeapartmentName { get; set; }
        public virtual ICollection <Employee>? Employees {get;set;}
        
    }
}