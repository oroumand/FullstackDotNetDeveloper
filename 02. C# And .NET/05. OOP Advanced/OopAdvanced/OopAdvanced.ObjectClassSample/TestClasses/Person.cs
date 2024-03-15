using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopAdvanced.ObjectClassSample.TestClasses
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }
    }

    public class Student
    {
        public string FirstName { get; set; }  
        public string LastName { get; set; }
        public string StudentNumber { get; set; }
        public override string ToString()
        {
            return $"{FirstName} {LastName} {StudentNumber}";
        }
    }

    public class Temp
    {

    }
}
