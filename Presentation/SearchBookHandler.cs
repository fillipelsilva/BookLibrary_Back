using Core.Entities;
using Core.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation
{
    public class SearchBookHandler : IRequestHandler<BookAddCommand, bool>
    {
        private readonly IMediatorHandler _mediatorHandler;
        private readonly IBookRepository _bookRepository;

        public SearchBookHandler(IMediatorHandler mediatorHandler, IBookRepository bookRepository)
        {
            _mediatorHandler = mediatorHandler;
            _bookRepository = bookRepository;
        }

        async Task<bool> IRequestHandler<BookAddCommand, bool>.Handle(BookAddCommand request, CancellationToken cancellationToken)
        {
            var book = new Book(request.BookId, request.Title, request.FirstName, request.LastName, request.TotalCopies, request.CopiesInUse, request.Type, request.Isbn, request.Category);
            await _bookRepository.Create(book);
            return true;
        }
    }
}
