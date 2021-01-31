using System;
using System.Collections.Generic;
using System.Linq;
using LibrarySystem.Application.Interfaces;
using LibrarySystem.Application.ResourceParameter;
using LibrarySystem.Data.Context;
using LibrarySystem.Domain.Entities;

namespace LibrarySystem.Application.Services
{
    public class BooksService : IBooksService
    {
        private readonly LibraryDbContext _context;
        public BooksService(LibraryDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }
        private IEnumerable<Book> GetBooks()
        {
            return _context.Books.OrderBy(c => c.Name).ToList();
        }

        public IEnumerable<Book> GetBooks(BookResourceParameter bookResourceParameter)
        {

            if (string.IsNullOrWhiteSpace(bookResourceParameter.MainCategory) || string.IsNullOrWhiteSpace(bookResourceParameter.SubCategory))
                return GetBooks();
            var collection = _context.Books as IQueryable<Book>;
            if (!string.IsNullOrWhiteSpace(bookResourceParameter.MainCategory))
            {
                var mainCategory = bookResourceParameter.MainCategory.Trim();
                collection = collection.Where(a => a.MainCategory == mainCategory);
            }

            if (string.IsNullOrWhiteSpace(bookResourceParameter.SubCategory)) return collection.ToList();
            {
                var subCategory = bookResourceParameter.SubCategory.Trim();
                collection = collection.Where(a => a.SubCategory == subCategory);
            }

            return collection.ToList();
        }

    }
}
