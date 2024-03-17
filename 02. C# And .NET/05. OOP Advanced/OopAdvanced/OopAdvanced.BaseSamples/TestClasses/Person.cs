using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopAdvanced.BaseSamples.TestClasses
{
    public class Person
    {
        public Person(string firstName,string lastName)
        {
            FirstName = firstName;
            LastName = lastName;

            Console.WriteLine($"Person Constructor {FirstName} {LastName}");
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }
    }

    public class Student : Person
    {
        public Student(string firstName,string lastName,string studentNumber):base(firstName,lastName)
        {
            StudentNumber = studentNumber;

            Console.WriteLine($"Student Constructor {FirstName} {LastName}");

        }
        public string StudentNumber { get; set; }
        public override string ToString()
        {
            return $"{base.ToString()} {StudentNumber}";
        }
    }

    public class Temp
    {

    }
}
