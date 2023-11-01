using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace dotnet.Models
{
    public class ApplicationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("User ID=sa;password=examlyMssql@123;server=localhost;Database=DonorDb;trusted_connection=false;Persist Security Info=false;Encrypt=false");
        }
        public virtual DbSet<Dealer>Dealers {set;get;}
    }
}