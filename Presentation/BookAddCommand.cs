using Core.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation
{
    public class BookAddCommand : Command
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
        public BookAddCommand(int bookId, string title, string firstName, string lastName, int totalCopies, int copiesInUse, string type, string isbn, string category)
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

        public bool Validate()
        {
            if (string.IsNullOrWhiteSpace(Title) || Title.Length > 100)
                return false;

            if (string.IsNullOrWhiteSpace(FirstName) || FirstName.Length > 50)
                return false;

            if (string.IsNullOrWhiteSpace(LastName) || LastName.Length > 50)
                return false;

            if (TotalCopies < 0)
                return false;

            if (CopiesInUse < 0 || CopiesInUse > TotalCopies)
                return false;

            if (string.IsNullOrWhiteSpace(Type) || Type.Length > 50)
                return false;

            if (string.IsNullOrWhiteSpace(Isbn) || Isbn.Length > 80)
                return false;

            if (string.IsNullOrWhiteSpace(Category) || Category.Length > 50)
                return false;

            return true;
        }
    }
}
