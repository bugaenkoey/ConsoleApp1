using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace ProductStorage
{
    class MyDbContext : DbContext
    {
        public MyDbContext() : base()
        {
            Database.EnsureCreated();
        }
        public DbSet<ProviderProduct> ProviderProducts { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = @"Data Source=LAPTOP-046QU23H\SQLEXPRESS;Initial Catalog=ProductStorage;Integrated Security=True;";

            //    var connectionString = @"Data Source=SZHIZHKONB1\SQLEXPRESS;Initial Catalog=GeneratedLibrary;Integrated Security=True;";
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}
