using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Models
{
    public class ApplicationDbContext
    {
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public DateTime Joindate { get; set; }
        public int MyProperty { get; set; }
    }
}