using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;
using System.Net.Http.Json;
using System.Reflection.Emit;
using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace Infrastructure.Context
{
    public class BookContext : DbContext
    {
        private readonly IConfiguration _configuration;
        private readonly string baseDirectory = Environment.CurrentDirectory;

        public BookContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public DbSet<Book> Book { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_configuration.GetConnectionString("BookDb"));
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            SetBookDataFromFile(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(BookContext).Assembly);
        }

        private void SetBookDataFromFile(ModelBuilder modelBuilder)
        {
            string questoesPath = Path.Combine(baseDirectory, "Books.json");
            string jsonContent = File.ReadAllText(questoesPath);

            List<Book> books = JsonConvert.DeserializeObject<List<Book>>(jsonContent);

            foreach (var book in books)
            {
                modelBuilder.Entity<Book>()
                .HasData(new Book(book.BookId, book.Title, book.FirstName, book.LastName, book.TotalCopies, book.CopiesInUse, book.Type, book.Isbn, book.Category));
            }
        }
    }
}
