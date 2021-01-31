using LibrarySystem.Domain.Entities;
using System.Collections.Generic;
using LibrarySystem.Application.ResourceParameter;

namespace LibrarySystem.Application.Interfaces
{
    public interface IBooksService
    {
        IEnumerable<Book> GetBooks(BookResourceParameter parameter);

    }
}
