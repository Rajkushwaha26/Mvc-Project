using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeApi.Models
{
    public class EmployeeDbContext : DbContect
    {
        
    }
    public EmloyeeDbContext(DbContext<EmployeeDbContext>options):base(options){

    }
        public virtual DbSet<Employee> Employees {get;set;}
        public virtual DbSet<Department> Departments {get;set;}
        public virtual DbSet<Designation> Designations {get;set;}
    
}