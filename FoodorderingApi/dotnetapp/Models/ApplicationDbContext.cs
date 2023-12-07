using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Microsoft.EntitryFrameworkcore;

namespace dotnetapp.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options): base(options){

        }

        public DbSet <AddressDetail>AddressDetail {get;set;}
        public DbSet <CartItem>CartItems {get;set;}
        public DbSet <Menu>Menus {get;set;}
        public DbSet <OrderDetail>OrderDetails {get;set;}
        public DbSet <Payment>Payments {get;set;}
        public DbSet <Role>Roles {get;set;}
        public DbSet <User>Users {get;set;}
        
    }
}