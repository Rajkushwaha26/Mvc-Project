using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Tution.Models
{
    public class ApplicationDbContext : DbContext
    {
        public class ApplicationDbContext(){

        }
        public ApplicationDbContext (DbContextOptions <ApplicationDbContext> options) : base(options){

        }
        protected override void OnConfiguration()
        
    }
}