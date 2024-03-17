using Core.Entities;
using Core.Interfaces;
using Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class BookRepository : IBookRepository 
    {
        protected BookContext _context;
        protected DbSet<Book> _dbSet;

        public BookRepository(BookContext context)
        {
            _dbSet = context.Set<Book>();
            _context = context;
        }

        public List<Book> SearchBookByFilters(string type, string value)
        {
            var query = _dbSet.AsQueryable();

            if (type != null && value  != null)
            {
                query = query
                   .Where(x => x.Type == type && x.Title.Contains(value))
                   .AsNoTracking();
            }

            return query.ToList();
        }
    }
}
