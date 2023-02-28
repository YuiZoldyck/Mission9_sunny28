using System;
using System.Linq;

namespace Mission9_sunny28.Models
{
    public class EFBooklistRepository:IBookstoreRepository
    {
        private BookstoreContext context { get; set; }

        public EFBooklistRepository (BookstoreContext temp)
        {
            context = temp;
        }

        public IQueryable<Book> Books => context.Books;
    }
}
