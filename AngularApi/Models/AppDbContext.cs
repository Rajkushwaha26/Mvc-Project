using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AngularApi.Models;
using Microsoft.EntityFrameworkCore;

namespace AngularApi.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext (){


        }

        public AppDbContext(DbContextOptions<AppDbContext>options):base(options){

        }

        public DbSet <Student> Students {get;set;}
    }
}