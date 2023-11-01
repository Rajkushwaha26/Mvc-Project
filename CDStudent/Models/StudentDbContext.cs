using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace CDStudent.Models
{
    public class StudentDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder options){
            options.UseSqlServer("User ID=sa; password=examlyMyssql@123; server=localhost;Database=StudentDB; trusted_connection=false; Persist Security Info=false; Encrypt=false; ");
        }
        public virtual DbSet<Student> Students{set;get;}
        
    }
}