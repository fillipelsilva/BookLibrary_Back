﻿// <auto-generated />
using Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Infrastructure.Migrations
{
    [DbContext(typeof(BookContext))]
    partial class BookContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.17")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Core.Entities.Book", b =>
                {
                    b.Property<int>("BookId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BookId"));

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasColumnName("category");

                    b.Property<int>("CopiesInUse")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0)
                        .HasColumnName("copies_in_use");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasColumnName("first_name");

                    b.Property<string>("Isbn")
                        .IsRequired()
                        .HasColumnType("varchar(80)")
                        .HasColumnName("isbn");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasColumnName("last_name");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("varchar(100)")
                        .HasColumnName("title");

                    b.Property<int>("TotalCopies")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0)
                        .HasColumnName("total_copies");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasColumnName("type");

                    b.HasKey("BookId")
                        .HasName("book_id");

                    b.ToTable("Book", (string)null);

                    b.HasData(
                        new
                        {
                            BookId = 1,
                            Category = "Fiction",
                            CopiesInUse = 80,
                            FirstName = "Jane",
                            Isbn = "1234567891",
                            LastName = "Austen",
                            Title = "Pride and Prejudice",
                            TotalCopies = 100,
                            Type = "Hardcover"
                        },
                        new
                        {
                            BookId = 2,
                            Category = "Fiction",
                            CopiesInUse = 65,
                            FirstName = "Harper",
                            Isbn = "1234567892",
                            LastName = "Lee",
                            Title = "To Kill a Mockingbird",
                            TotalCopies = 75,
                            Type = "Paperback"
                        },
                        new
                        {
                            BookId = 3,
                            Category = "Fiction",
                            CopiesInUse = 45,
                            FirstName = "J.D.",
                            Isbn = "1234567893",
                            LastName = "Salinger",
                            Title = "The Catcher in the Rye",
                            TotalCopies = 50,
                            Type = "Hardcover"
                        },
                        new
                        {
                            BookId = 4,
                            Category = "Non-Fiction",
                            CopiesInUse = 22,
                            FirstName = "F. Scott",
                            Isbn = "1234567894",
                            LastName = "Fitzgerald",
                            Title = "The Great Gatsby",
                            TotalCopies = 50,
                            Type = "Hardcover"
                        },
                        new
                        {
                            BookId = 5,
                            Category = "Biography",
                            CopiesInUse = 35,
                            FirstName = "Paulo",
                            Isbn = "1234567895",
                            LastName = "Coelho",
                            Title = "The Alchemist",
                            TotalCopies = 50,
                            Type = "Hardcover"
                        },
                        new
                        {
                            BookId = 6,
                            Category = "Mystery",
                            CopiesInUse = 11,
                            FirstName = "Markus",
                            Isbn = "1234567896",
                            LastName = "Zusak",
                            Title = "The Book Thief",
                            TotalCopies = 75,
                            Type = "Hardcover"
                        },
                        new
                        {
                            BookId = 7,
                            Category = "Sci-Fi",
                            CopiesInUse = 14,
                            FirstName = "C.S.",
                            Isbn = "1234567897",
                            LastName = "Lewis",
                            Title = "The Chronicles of Narnia",
                            TotalCopies = 100,
                            Type = "Paperback"
                        },
                        new
                        {
                            BookId = 8,
                            Category = "Sci-Fi",
                            CopiesInUse = 40,
                            FirstName = "Dan",
                            Isbn = "1234567898",
                            LastName = "Brown",
                            Title = "The Da Vinci Code",
                            TotalCopies = 50,
                            Type = "Paperback"
                        },
                        new
                        {
                            BookId = 9,
                            Category = "Fiction",
                            CopiesInUse = 35,
                            FirstName = "John",
                            Isbn = "1234567899",
                            LastName = "Steinbeck",
                            Title = "The Grapes of Wrath",
                            TotalCopies = 50,
                            Type = "Hardcover"
                        },
                        new
                        {
                            BookId = 10,
                            Category = "Non-Fiction",
                            CopiesInUse = 35,
                            FirstName = "Douglas",
                            Isbn = "1234567900",
                            LastName = "Adams",
                            Title = "The Hitchhiker's Guide to the Galaxy",
                            TotalCopies = 50,
                            Type = "Paperback"
                        },
                        new
                        {
                            BookId = 11,
                            Category = "Fiction",
                            CopiesInUse = 8,
                            FirstName = "Herman",
                            Isbn = "8901234567",
                            LastName = "Melville",
                            Title = "Moby-Dick",
                            TotalCopies = 30,
                            Type = "Hardcover"
                        },
                        new
                        {
                            BookId = 12,
                            Category = "Non-Fiction",
                            CopiesInUse = 0,
                            FirstName = "Harper",
                            Isbn = "9012345678",
                            LastName = "Lee",
                            Title = "To Kill a Mockingbird",
                            TotalCopies = 20,
                            Type = "Paperback"
                        },
                        new
                        {
                            BookId = 13,
                            Category = "Non-Fiction",
                            CopiesInUse = 1,
                            FirstName = "J.D.",
                            Isbn = "0123456789",
                            LastName = "Salinger",
                            Title = "The Catcher in the Rye",
                            TotalCopies = 10,
                            Type = "Hardcover"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
