using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using XamEFCore.Models;

namespace XamEFCore.DataContext
{
    public class AppDbContext : DbContext
    {
        String DbPath = string.Empty;
        public AppDbContext(string dbPath)
        {
            this.DbPath = dbPath;
        }
        public DbSet<Artista> Artistas { get; set; }
        public DbSet<Album> Albumes { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($"Filename={DbPath}");
        }

    }
}
