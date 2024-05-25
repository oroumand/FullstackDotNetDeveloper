namespace GenericSamples.DictionarySamples
{
    public class Student(string firstName, string lastName, string studentNumber, string Maghtae, int avg)
    {
        public string FirstName { get; set; } = firstName;
        public string LastName { get; set; } = lastName;
        public string StudentNumber { get; set; } = studentNumber;
        public string Maghta { get; set; } = Maghtae;
        public int Avg { get; set; } = avg;
    }
}
