using Microsoft.AspNetCore.Mvc;
using Presentation.Interfaces;
using Presentation.ViewModels;

namespace BookLibrary.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IBookAppService _bookService;

        public BookController(IBookAppService bookService)
        {
            _bookService = bookService;
        }

        [HttpPost("SearchBook")]
        public IActionResult SearchBook(BookSearchViewModel bookSearchViewModel)
        {
            return Ok(_bookService.SearchBookByFilters(bookSearchViewModel));
        }

        [HttpPost("CreateBook")]
        public async Task<IActionResult> CreateBook(BookViewModel bookViewModel)
        {
            return Ok(await _bookService.BookViewModel(bookViewModel) ? "Book inserted" : "Book incorrect");
        }
    }
}
