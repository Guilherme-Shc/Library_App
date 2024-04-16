using Library.Communication.Enums;

namespace Library.Communication.Responses
{
    public class ResponseBookJson
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Author { get; set; } = string.Empty;
        public BookGenre GenreType { get; set; }
        public int Value { get; set; }
        public int Quantity { get; set; }
    }
}
