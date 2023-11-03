using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EmployeeApi.Models;

namespace EmployeeApi.Models
{
    public class EmployeeDbContext : DbContext
    {
        public EmployeeDbContext(DbContextOptions <EmployeeDbContext> options ) : base(options){

        }
        public virtual DbSet<Employee> Employees {get;set;}
        public virtual DbSet<Department> Departments {get;set;}
        public virtual DbSet<Degination> Deginations {get;set;}
        
    }
}