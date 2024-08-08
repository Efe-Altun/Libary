using AutoMapper;
using Libary.Books;

namespace Libary;

public class LibaryApplicationAutoMapperProfile : Profile
{
    public LibaryApplicationAutoMapperProfile()
    {
        CreateMap<Book, BookDto>();
        CreateMap<CreateUpdateBookDto, Book>();
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */
    }
}
