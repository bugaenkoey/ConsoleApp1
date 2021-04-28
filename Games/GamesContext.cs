using Games.DataAccessLayer.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Games
{
   public class GamesContext:DbContext
    {
        public DbSet<Game> Games { get; set; }
        public GamesContext()
        {
           // Database.EnsureDeleted();
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //@"Data Source=LAPTOP-046QU23H\SQLEXPRESS;Integrated Security=True;"
           // optionsBuilder.UseSqlServer(@"Data Source=LAPTOP-046QU23H\SQLEXPRESS;Database=EF_Games2;Integrated Security=True;");
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=EF_Games;Trusted_Connection=True;");
        }
    }
}
