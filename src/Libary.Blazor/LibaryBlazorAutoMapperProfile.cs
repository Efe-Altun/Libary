using AutoMapper;
using Libary.Books;

namespace Libary.Blazor;

public class LibaryBlazorAutoMapperProfile : Profile
{
    public LibaryBlazorAutoMapperProfile()
    {
        CreateMap<BookDto, CreateUpdateBookDto>();
        
        //Define your AutoMapper configuration here for the Blazor project.
    }
}
