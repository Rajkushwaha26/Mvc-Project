using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace EmployeeApi.Models
{
    public class Degination
    {
        public int DeginationId { get; set; }
        public int DeginationName { get; set; }
        public ICollection<Employee>? Employees { get; set; }
    }
}