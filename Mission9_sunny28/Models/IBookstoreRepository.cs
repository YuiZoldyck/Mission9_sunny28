using System;
using System.Linq;

namespace Mission9_sunny28.Models
{
    public interface IBookstoreRepository
    {
       IQueryable<Book> Books { get; }
    }
}
