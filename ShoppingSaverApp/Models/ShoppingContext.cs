using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace ShoppingSaverApp.Models
{
    public class ShoppingContext : DbContext
    {
        public ShoppingContext() : base()
        {

        }

        public DbSet<Person> Persons { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Shop> Shops { get; set; }
        public DbSet<Receipt> Receipts { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}