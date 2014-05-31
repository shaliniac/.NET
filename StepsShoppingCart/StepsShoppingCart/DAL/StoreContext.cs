
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using StepsShoppingCart.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace StepsShoppingCart.DAL
{
    
        public class StoreContext : DbContext
        {

            public DbSet<ProductViewModel> Products { get; set; }
           /* public DbSet<Customer> Customers { get; set; }
            public DbSet<Product> Products { get; set; }
            public DbSet<ShoppingCart> ShoppingCarts { get; set; }


            protected override void OnModelCreating(DbModelBuilder modelBuilder)
            {
                modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            }
            * */
        }
    }


