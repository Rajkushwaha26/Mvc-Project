using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace dotnetapp.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options): base(options){

        }

        public virtual DbSet<AddressDetail>AddressDetails {get;set;}
       // public virtual DbSet<AddressDetail>AddressDetail {get;set;}

        public virtual DbSet<CartItem>CartItems {get;set;}

        public virtual DbSet<Menu>Menus {get;set;}

        public virtual DbSet<OrderDetail>OrderDetails {get;set;}

        public virtual DbSet<Payment>Payments {get;set;}

        public virtual DbSet<Role>Roles {get;set;}

        public virtual DbSet<User>Users {get;set;}

        
    }
}