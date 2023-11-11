using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WEBAPI.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(AppDbContextOptions<AppDbContext>options):base(options){

        }
        public DbSet<PG>PGs {get;set;}
        
    }
}