using System;
using System.Collections.Generic;
using System.Text;
using LibrarySystem.Domain.Entities;

namespace LibrarySystem.Data.Interfaces
{
    public interface IBooksRepository
    {
        IEnumerable<Book> GetBooks(string mainCategory, string subCategory);
    }
}
