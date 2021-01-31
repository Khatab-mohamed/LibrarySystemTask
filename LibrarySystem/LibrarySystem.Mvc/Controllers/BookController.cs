using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibrarySystem.Application.Interfaces;
using LibrarySystem.Application.ResourceParameter;
using LibrarySystem.Application.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace LibrarySystem.Mvc.Controllers
{
    public class BookController : Controller
    {
        private readonly IBooksService _booksService;

        public BookController(IBooksService booksService)
        {
            _booksService = booksService;
        }

        public IActionResult Index([FromBody] BookResourceParameter bookResourceParameter)
        {
            BooksViewModel model = _booksService.GetBooks(bookResourceParameter);
            return View(model);
        }
    }
}
