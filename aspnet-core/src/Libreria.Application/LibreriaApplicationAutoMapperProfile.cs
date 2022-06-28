using AutoMapper;
using Libreria.Authors;

namespace Libreria;

public class LibreriaApplicationAutoMapperProfile : Profile
{
    public LibreriaApplicationAutoMapperProfile()
    {
        CreateMap<Author, AuthorDto>();
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */
    }
}
