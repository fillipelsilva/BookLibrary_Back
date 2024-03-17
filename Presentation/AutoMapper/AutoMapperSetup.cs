using AutoMapper;
using Core.Entities;
using Microsoft.EntityFrameworkCore.Query.Internal;
using Presentation.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation.AutoMapper
{
    public class AutoMapperSetup : Profile
    {
        public AutoMapperSetup()
        {
            CreateMap<BookViewModel, Book>();
            CreateMap<Book, BookViewModel>();
            
        }
    }
}
