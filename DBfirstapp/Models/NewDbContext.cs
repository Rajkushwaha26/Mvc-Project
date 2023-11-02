using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBfirstapp.Models
{
    public class NewDbContext : DbContext
    {
        public NewDbContext(){

        }
        public NewDbContext (DbContextOptions <NewDbContext> options):base(options){

        }
        protected override void OnConfiguring(DbContextOptionsBuilder options ){
            options.UseSqlServer("User id=")
        }
        public virtual DbSet<dealer>dealers{get;set;}
    }
}