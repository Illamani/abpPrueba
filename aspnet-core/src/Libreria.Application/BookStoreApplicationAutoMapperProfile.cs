using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Libreria.Books;
using Microsoft.PowerBI.Api.Models;
using Volo.Abp.AutoMapper;

namespace Libreria
{
    public class BookStoreApplicationAutoMapperProfile : Profile
    {
        public BookStoreApplicationAutoMapperProfile()
        {
            //CreateMap<AppUser,AppUser>().Ignore(x => x.ExtraProperties);
            CreateMap<Book, BookDto>();
            CreateMap<CreateUpdateBookDto, Book>();
        }
    }
}
