using System;
using System.Collections.Generic;
using System.Text;
using DatabaseAccess.Models;
using Microsoft.EntityFrameworkCore;

namespace DatabaseAccess.DAL
{
    public class BookDbContext:DbContext
    {
        public BookDbContext(DbContextOptions<BookDbContext> options) : base(options) 
        {
            Database.EnsureCreated();   
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Models.Rent> Rents { get; set; }
    }
}
