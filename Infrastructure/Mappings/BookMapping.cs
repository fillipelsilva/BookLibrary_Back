using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Mappings
{
    public class BookMapping : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.ToTable("Book");

            builder.HasKey(p => p.BookId)
                .HasName("book_id");

            builder.Property(p => p.Title)
                .HasColumnName("title")
                .HasColumnType("varchar(100)");

            builder.Property(p => p.FirstName)
                .HasColumnName("first_name")
                .HasColumnType("varchar(50)");

            builder.Property(p => p.LastName)
                .HasColumnName("last_name")
                .HasColumnType("varchar(50)");

            builder.Property(p => p.TotalCopies)
                .HasDefaultValue(0)
                .IsRequired()
                .HasColumnName("total_copies")
                .HasColumnType("int");

            builder.Property(p => p.CopiesInUse)
                .HasDefaultValue(0)
                .IsRequired()
                .HasColumnName("copies_in_use")
                .HasColumnType("int");

            builder.Property(p => p.Type)
                .HasColumnName("type")
                .HasColumnType("varchar(50)");

            builder.Property(p => p.Isbn)
                .HasColumnName("isbn")
                .HasColumnType("varchar(80)");

            builder.Property(p => p.Category)
                .HasColumnName("category")
                .HasColumnType("varchar(50)");
        }
    }
}
