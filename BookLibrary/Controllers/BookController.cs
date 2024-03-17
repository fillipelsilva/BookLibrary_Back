using Microsoft.AspNetCore.Mvc;
using Presentation.Interfaces;
using Presentation.ViewModels;

namespace BookLibrary.Controllers
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
    }

    [HttpPost("SearchBook")]
    public IActionResult SearchBook(BookSearchViewModel bookSearchViewModel)
    {
        return Ok(IBookAppService.SearchBookByFilters(bookSearchViewModel));
    }
}
