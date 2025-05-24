using Library.API.Models;
using Library.API.Services;

namespace Library.API.GraphQL.Queries
{
    public class BookQuery
    {
        [UseFiltering]
        [UseSorting]
        public IQueryable<Book> GetBooks([Service] BookService service) =>
      service.GetAll().AsQueryable();

        public IEnumerable<Book> GetBooksByAuthor(string author, [Service] BookService service) =>
            service.GetByAuthor(author);
    }
}
