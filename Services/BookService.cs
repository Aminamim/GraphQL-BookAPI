using Library.API.Models;

namespace Library.API.Services
{
    public class BookService
    {
        private readonly List<Book> _books = new();
        private int _nextId = 1;

        public IEnumerable<Book> GetAll() => _books;

        public IEnumerable<Book> GetByAuthor(string author) =>
            _books.Where(b => b.Author.Equals(author, StringComparison.OrdinalIgnoreCase));

        public Book Add(BookInput input)
        {
            var book = new Book
            {
                Id = _nextId++,
                Title = input.Title,
                Author = input.Author,
                Year = input.Year
            };
            _books.Add(book);
            return book;
        }
        public bool DeleteBook(int id)
        {
            var book = _books.FirstOrDefault(b => b.Id == id);
            if (book is null) return false;
            _books.Remove(book);
            return true;
        }
    }
}
