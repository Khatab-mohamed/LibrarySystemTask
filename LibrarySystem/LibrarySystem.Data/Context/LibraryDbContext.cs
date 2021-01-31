using System;
using System.Collections.Generic;
using System.Text;
using LibrarySystem.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace LibrarySystem.Data.Context
{
    public class LibraryDbContext : DbContext
    {
        private readonly DbContextOptions<LibraryDbContext> _options;

        public LibraryDbContext(DbContextOptions<LibraryDbContext> options) : base(options)
        {
            _options = options;
        }
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }

    }
}
