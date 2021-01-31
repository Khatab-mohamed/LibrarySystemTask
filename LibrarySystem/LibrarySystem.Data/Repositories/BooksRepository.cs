using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LibrarySystem.Data.Context;
using LibrarySystem.Data.Interfaces;
using LibrarySystem.Domain.Entities;

namespace LibrarySystem.Data.Repositories
{
    public class BooksRepository :IBooksRepository
    {
        private readonly LibraryDbContext _context;
        public BooksRepository(LibraryDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }
        private IEnumerable<Book> GetBooks()
        {
            return _context.Books.OrderBy(c => c.Name).ToList();
        }

        public IEnumerable<Book> GetBooks(string _mainCategory, string _subCategory)
        {

            if (string.IsNullOrWhiteSpace(_mainCategory) || string.IsNullOrWhiteSpace(_subCategory))
                return GetBooks();
            var collection = _context.Books as IQueryable<Book>;
            if (!string.IsNullOrWhiteSpace(_mainCategory))
            {
                var mainCategory = _mainCategory.Trim();
                collection = collection.Where(a => a.MainCategory == mainCategory);
            }

            if (string.IsNullOrWhiteSpace(_mainCategory)) return collection.ToList();
            {
                var subCategory = _subCategory.Trim();
                collection = collection.Where(a => a.SubCategory == subCategory);
            }

            return collection.ToList();
        }

    }
}
