using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CodeFirstA.Models;


namespace CodeFirstA.Models
{
    public class StudentDBContext : DbContext
    {
        //public StudentDBContext(DbContextOptions options) : base(options)
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("User ID = sa; password = examlyMssql@123; MultipleActiveResultSets = true; server = localhost; Database = StudentDB;connection = False; Persist Security Info = False; Encrypt = False");
        }
        public DbSet<student> Students { get; set; }
    }
}