using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionSamples.ThrowEx
{
    public class Person
    {
        public string FullName { get; set; }
        public int Age { get; set; }
        public Person(string fullName, int age)
        {
            if (string.IsNullOrEmpty(fullName))
            {
                throw new ArgumentNullException("value of full name can not be null or empty.");
            }
            if (age < 0)
            {
                throw new ArgumentOutOfRangeException("Age should ne grater than 0");
            }
            FullName = fullName;
            Age = age;
        }
    }
}
