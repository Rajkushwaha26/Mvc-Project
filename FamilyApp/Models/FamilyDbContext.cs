using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace FamilyApp.Models
{
    public class FamilyDbContext : DbContext
    {
        public FamilyDbContext(DbContextOptions<FamilyDbContext>options):base(options){

        }
        
        public virtual DbSet<Detail>Details {set;get;}
        
        
        
    }
}