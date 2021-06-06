namespace CSharp9WhatsNew
{
    // Init-only Setters
    // Difference between get-only, private set, init set
    public class Person
    {
        public Person()
        {
        }

        // Old Approach: much boilerplate code to support construction
        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public string FirstName { get; init; }

        public string LastName { get; init; }

        public string DisplayName => $"{FirstName} {LastName}";
    }
}
