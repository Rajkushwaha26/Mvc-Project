using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace dotnet.Models
{
    public class NewDbContext : DbContext
    {
        public NewDbContext(){

        }
        public NewDbContext (DbContextOptions <NewDbContext> options) : base(options){

        }
        protected override void OnConfiguring(DbContextOptionsBuilder op)
        
    }
}