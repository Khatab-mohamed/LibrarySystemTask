using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibrarySystem.Application.Interfaces;
using LibrarySystem.Application.ResourceParameter;
using LibrarySystem.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LibrarySystem.Mvc.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly IBooksService _booksService;

        public BooksController(IBooksService booksService)
        {
            _booksService = booksService;
        }


        [HttpGet]
        [HttpHead]
        public ActionResult<IEnumerable<Book>> GetAuthors(
            [FromQuery] BookResourceParameter bookResourceParameter)
        {
            var books = _booksService.GetBooks(bookResourceParameter);

            return Ok(books);
        }
    }
}
