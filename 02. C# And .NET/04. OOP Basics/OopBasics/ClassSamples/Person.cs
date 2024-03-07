namespace ClassSamples
{
    public class Person
    {
        public string firstName;
        public string lastName;
        public int age;

        public const int AdultAge = 18 - 9 + 5 + 4;

        public readonly int AdultAgeReadOnly;
        public Person(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            AdultAgeReadOnly = GetAdultAge();
        }


        public int GetAdultAge() => 20;

        public void Rename(string newName)
        {
            firstName = newName;
            PersonPrinter printer = new();
            printer.Print(this);


        }

        public void ForAdults()
        {
            if (age > AdultAge)
            {

            }
        }

    }
}
