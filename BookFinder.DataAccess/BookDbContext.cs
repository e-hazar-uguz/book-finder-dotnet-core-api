using BookFinder.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookFinder.DataAccess
{
    public class BookDbContext:DbContext 
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=DESKTOP-77RK7N2;Database=BookDb;uid=sa;pwd=123;");
        }

        public DbSet<Book> Books { get; set; }
    }
}
