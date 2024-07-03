using System;
using Microsoft.EntityFrameworkCore;

namespace LezzetAvcısıBlog.Models
{
	public class WebContext : DbContext
	{
        public DbSet<Kullanici> Kullanici { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql("Server=localhost;Database=LezzetAvcisi;User=root;Password=x;", new MySqlServerVersion(new Version(8, 0, 21)));
        }
        
    }
}

