using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface IBookRepository 
    {
        List<Book> SearchBookByFilters(string type, string value);
    }
}
