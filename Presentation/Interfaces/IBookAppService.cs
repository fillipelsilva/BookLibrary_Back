using Presentation.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation.Interfaces
{
    public interface IBookAppService
    {
        Task<bool> BookViewModel(BookViewModel bookViewModel);
        List<BookViewModel> SearchBookByFilters(BookSearchViewModel bookSearchViewModel);
    }
}
