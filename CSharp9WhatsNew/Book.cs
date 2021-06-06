namespace CSharp9WhatsNew
{
    // Records
    // A new reference type immutable by design.
    // Saves us from writing boilerplate code.
    // Generated as a class in IL.
    public record BaseBookRecord(string Title, string AuthorName, int Year, decimal Price);

    // Records cannot inherit from classes, unless the class is object, and classes cannot inherit from records.
    // Records can inherit from other records.
    public record DerivedBookRecord(string Title, string AuthorName, int Year, decimal Price, string Genre)
        : BaseBookRecord(Title, AuthorName, Year, Price);

    // Old Approach: class type with all properties
    public class Book
    {
        public string Title { get; init; }

        public string AuthorName { get; init; }

        public int Year { get; init; }

        public decimal Price { get; init; }
    }
}
