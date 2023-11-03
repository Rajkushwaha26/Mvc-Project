using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApp.Models;


namespace WebApp.Models
{
    public class EmployeeDbContext : DbContext
    {
        
        public EmployeeDbContect(DbContextOptions <EmployeeDbContext> options ) : base(options){

        }
        public virtual DbSet<Employee> Employees {get;set;}
        public virtual DbSet<Department> Departments {get;set;}
        public virtual DbSet<Designation> Designations {get;set;}

    }
}