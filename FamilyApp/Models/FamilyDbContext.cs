using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace FamilyApp.Models
{
    public class FamilyDbContext : DbContext
    {
        public 
        
        public virtual DbSet<BloodDonor>BloodDonors {set;get;}
        
        
        
    }
}