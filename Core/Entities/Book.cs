using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Book 
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int TotalCopies { get; set; }
        public int CopiesInUse { get; set; }
        public string Type { get; set; }
        public string Isbn { get; set; }
        public string Category { get; set; }
        public Book(int bookId, string title, string firstName, string lastName, int totalCopies, int copiesInUse, string type, string isbn, string category)
        {
            BookId = bookId;
            Title = title;
            FirstName = firstName;
            LastName = lastName;
            TotalCopies = totalCopies;
            CopiesInUse = copiesInUse;
            Type = type;
            Isbn = isbn;
            Category = category;
        }

        protected Book() { }

    }
}
