using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Realme.Data
{
    public class RealmeDBContext : DbContext
    {
        
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("User ID = sa; password = examlyMssql@123; MultipleActiveResultSets = true; server = localhost; Database = RealmeDB; trusted_connection = False; Persist Security Info = False; Encrypt = False");
        }

        public virtual DbSet<Department> Departments {set; get;}
        public virtual DbSet<Employee> Books {set; get;}
    }
}