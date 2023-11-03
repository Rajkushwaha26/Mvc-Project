using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options){

        }
        public DbSet <Employee>Employees {get;set;}
        public DbSet<Department>Departments {get;set;}
        public DbSet<Designation>Designations{get;set;}
    }
}