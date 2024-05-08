namespace GradePrinter.Models
{
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Grade { get; set; }
        public override string ToString() =>
            $@"First Name: {FirstName}, Last Name: 
            {LastName} Grade: {Grade}";

    }
}
