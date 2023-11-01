using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CodeToData.Data
{
    public class NewDataDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder options)
         {
            options.UseSqlServer("User ID=sa; password=examlyMssql@123;server=localhost; Database=NewDataDb; trusted_connection=false; Persist Security Info = False; Encrypt = False");
        }
        public virtual Department? Deparments {set; get;}
        public virtual Employee? Employees {set; get;}
    }
}