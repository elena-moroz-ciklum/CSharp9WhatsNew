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
            
            var bookRecord = new BaseBookRecord("A Man Called Ove", "Fredrik Backman", 2012, 25); // new approach
            // bookRecord.Title = "Anxious People"; // error
            var bookRecord2 = new BaseBookRecord("A Man Called Ove", "Fredrik Backman", 2012, 25);
            var bookRecord3 = bookRecord2 with {Title = "Anxious People"};
            
            Console.WriteLine(bookRecord);
            Console.WriteLine(bookRecord2);
            Console.WriteLine(bookRecord3);
            
            Console.WriteLine(bookRecord == bookRecord2);

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
