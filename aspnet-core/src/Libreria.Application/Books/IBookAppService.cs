using Libreria.Permissions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;


namespace Libreria.Books
{
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
            GetPolicyName = LibreriaPermissions.Books.Default;
            GetListPolicyName = LibreriaPermissions.Books.Default;
            CreatePolicyName = LibreriaPermissions.Books.Create;
            UpdatePolicyName = LibreriaPermissions.Books.Edit;
            DeletePolicyName = LibreriaPermissions.Books.Delete;    
        }
    }
}
