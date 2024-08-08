using System;
using System.Threading.Tasks;
using Libary.Permissions;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Libary.Books;

public class BookAppService :
    CrudAppService<
        Book, //The Book entity
        BookDto, //Used to show books
        Guid, //Primary key of the book entity
        PagedAndSortedResultRequestDto, //Used for paging/sorting
        CreateUpdateBookDto>, //Used to create/update a book
    IBookAppService //implement the IBookAppService
{
    public BookAppService(IRepository<Book, Guid> repository)
        : base(repository)
    {
        GetPolicyName = LibaryPermissions.Books.Default;
        GetListPolicyName = LibaryPermissions.Books.Default;
        CreatePolicyName = LibaryPermissions.Books.Create;
        UpdatePolicyName = LibaryPermissions.Books.Edit;
        DeletePolicyName = LibaryPermissions.Books.Delete;
    }

    public Task GetListAsync()
    {
        throw new NotImplementedException();
    }
}