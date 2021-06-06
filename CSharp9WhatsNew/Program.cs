using System;

namespace CSharp9WhatsNew
{
    public class Program
    {
        public static void Main()
        {
            #region Init-only Setters

            var person = new Person // new approach
            {
                FirstName = "Elena",
                LastName = "Moroz",
            };
            // person.FirstName = "Olena"; // error
            Console.WriteLine(person.DisplayName);

            var person2 = new Person("Elena", "Moroz"); // old approach
            // person2.FirstName = "Olena"; // error
            Console.WriteLine(person2.DisplayName);

            #endregion

            #region Records
            
            var bookRecord = new BookRecord("A Man Called Ove", "Fredrik Backman", 2012, 25); // new approach
            // bookRecord.Title = "Anxious People"; // error
            Console.WriteLine(bookRecord);

            var book = new Book // old approach
            {
                Title = "A Man Called Ove",
                AuthorName = "Fredrik Backman",
                Year = 2012,
                Price = 25
            };
            // book.Title = "Anxious People"; // error
            Console.WriteLine(book.AuthorName);

            #endregion

            Console.ReadLine();
        }
    }
}
