using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace login.Models
{
    public class AppliactionDbContext : DbContext
    {
        AppliactionDbContext(){

        }
        public DbSet<Login>Logins {get;set;}
        public DbSet<Register>Registers {get;set;}

        
    }
}