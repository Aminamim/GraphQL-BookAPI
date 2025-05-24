using Library.API.Models;
using Library.API.Services;

namespace Library.API.GraphQL.Mutations
{
    public class BookMutation
    {
        public Book AddBook(BookInput input, [Service] BookService service) => service.Add(input);
        public IEnumerable<Book> AddBooks(
       List<BookInput> inputs,
       [Service] BookService repository)
        {
            var books = new List<Book>();

            foreach (var input in inputs)
            {
                var book = repository.Add(input);
                books.Add(book);
            }

            return books;
        }

        public bool DeleteBook(int id, [Service] BookService repository)
        {
            return repository.DeleteBook(id);
        }
    }
}
