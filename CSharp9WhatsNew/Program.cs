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

            Console.ReadLine();
        }
    }
}
