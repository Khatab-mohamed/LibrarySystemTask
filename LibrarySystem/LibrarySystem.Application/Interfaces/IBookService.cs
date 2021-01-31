using LibrarySystem.Application.ResourceParameter;
using LibrarySystem.Application.ViewModels;

namespace LibrarySystem.Application.Interfaces
{
    public interface IBooksService
    {
        BooksViewModel GetBooks(BookResourceParameter parameter);

    }
}
