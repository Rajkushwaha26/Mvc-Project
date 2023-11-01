using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CODEFIRSTAAP.Models
{
    public partial class BookDBContext : DbContext
    {
        
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("User ID = sa; password = examlyMssql@123; MultipleActiveResultSets = true; server = localhost; Database = BooksDB; trusted_connection = False; Persist Security Info = False; Encrypt = False");
        }

        public virtual DbSet<Book> Books {set; get;}
    }
}