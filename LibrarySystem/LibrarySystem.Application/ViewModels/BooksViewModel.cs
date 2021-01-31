using System;
using System.Collections.Generic;
using System.Text;
using LibrarySystem.Domain.Entities;

namespace LibrarySystem.Application.ViewModels
{
    public class BooksViewModel
    {
        public IEnumerable<Book> Books { get; set; }
    }
}
