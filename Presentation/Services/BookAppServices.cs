using AutoMapper;
using Core.Entities;
using Core.Interfaces;
using MediatR;
using Presentation.Interfaces;
using Presentation.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation.Services
{
    public class BookAppServices : IBookAppService
    {
        private readonly IBookRepository _booRepository;
        private readonly IMapper _mapper;
        private readonly IMediatorHandler _mediatorHandler;

        public BookAppServices(IBookRepository booRepository, IMapper mapper, IMediatorHandler mediatorHandler)
        {
            _booRepository = booRepository;
            _mapper = mapper;
            _mediatorHandler = mediatorHandler;
        }

        public async Task<bool> BookViewModel(BookViewModel bookViewModel)
        {
            var book = _mapper.Map<Book>(bookViewModel);
            var command = new BookAddCommand(book.BookId, book.Title, book.FirstName, book.LastName, book.TotalCopies, book.CopiesInUse, book.Type, book.Isbn, book.Category);

            if (!command.Validate())
                return false;

            return await _mediatorHandler.SendCommand(command);
        }

        public List<BookViewModel> SearchBookByFilters(BookSearchViewModel bookSearchViewModel)
        {
            return _mapper.Map<List<BookViewModel>>(_booRepository.SearchBookByFilters(bookSearchViewModel.Type, bookSearchViewModel.Value));
        }
    }
}
