// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;

// namespace MyMVCProj.Data
// {
    
    
//     public class CodeFirstDbContext : DbContext
//     {
//         protected override void OnConfiguring(DbContextOptionsBuilder options)
//         {
//             string conStr = "User ID=sa; password=examlyMssql@123;server=localhost; Database=NewDataDb; trusted_connection=false; Persist Security Info = False; Encrypt = False";
//             options.UseSqlServer(conStr);
//         }
//         public DbSet<Employee> Employees {set;get;}
//         public DbSet<Department> Departments {set;get;}

//     }

// }

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MvcCodeFirstApp.Data
{
    public class CodeFirstDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("User ID = sa; password = examlyMssql@123; MultipleActiveResultSets = true; server = localhost; Database = CodeFirstDb;connection = False; Persist Security Info = False; Encrypt = False");
        }

        public virtual DbSet<Department> Departments {set; get;}
        public virtual DbSet<Employee> Employees {set; get;}
    }
}