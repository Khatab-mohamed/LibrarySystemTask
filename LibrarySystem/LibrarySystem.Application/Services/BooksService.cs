using System;
using System.Collections.Generic;
using System.Linq;
using LibrarySystem.Application.Interfaces;
using LibrarySystem.Application.ResourceParameter;
using LibrarySystem.Application.ViewModels;
using LibrarySystem.Data.Context;
using LibrarySystem.Data.Interfaces;
using LibrarySystem.Domain.Entities;

namespace LibrarySystem.Application.Services
{
    public class BooksService : IBooksService
    {
        private readonly IBooksRepository _booksRepository;

        public BooksService(IBooksRepository booksRepository)
        {
            _booksRepository = booksRepository;
        }
        public BooksViewModel GetBooks(BookResourceParameter bookResourceParameter)
        {
            var mainCategory = bookResourceParameter.MainCategory;
            var subCategory = bookResourceParameter.SubCategory;
            return new BooksViewModel()
            {
                Books = _booksRepository.GetBooks(mainCategory,subCategory)
            };
        }

    }
}
