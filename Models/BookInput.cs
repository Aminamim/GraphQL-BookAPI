namespace Library.API.Models
{
    public class BookInput
    {
        public string Title { get; set; } = default!;
        public string Author { get; set; } = default!;
        public int Year { get; set; }
    }
}
