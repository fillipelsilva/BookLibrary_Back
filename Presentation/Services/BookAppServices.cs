using AutoMapper;
using Core.Interfaces;
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

        public BookAppServices(IBookRepository booRepository, IMapper mapper)
        {
            _booRepository = booRepository;
            _mapper = mapper;
        }

        public List<BookViewModel> SearchBookByFilters(BookSearchViewModel bookSearchViewModel)
        {
            return _mapper.Map<List<BookViewModel>>(_booRepository.SearchBookByFilters(bookSearchViewModel.Type, bookSearchViewModel.Value));
        }
    }
}
