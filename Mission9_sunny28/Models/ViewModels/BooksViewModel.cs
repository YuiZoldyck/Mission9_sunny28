using System;
using System.Linq;

namespace Mission9_sunny28.Models.ViewModels
{
    public class BooksViewModel
    {
        public IQueryable<Book> Books { get; set; }
        public PageInfo PageInfo { get; set; }

    }
}
