using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EF_Core
{
    class ApplicationContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public DbSet<Home> Homes { get; set; }
        public ApplicationContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //@"Data Source=LAPTOP-046QU23H\SQLEXPRESS;Integrated Security=True;"
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=EF_Cor;Trusted_Connection=True;");
        }
    }
}
