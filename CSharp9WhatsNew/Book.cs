namespace CSharp9WhatsNew
{
    // Records
    // A new reference type immutable by design
    // Saves us from writing boilerplate code
    // Generated as a class in IL
    public record BookRecord(string Title, string AuthorName, int Year, decimal Price);

    // Old Approach: class type with all properties
    public class Book
    {
        public string Title { get; init; }

        public string AuthorName { get; init; }

        public int Year { get; init; }

        public decimal Price { get; init; }
    }
}
