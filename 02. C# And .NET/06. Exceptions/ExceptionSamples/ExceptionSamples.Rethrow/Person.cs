using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionSamples.Rethrow
{
    public class Person
    {
        public string FirstName { get; set; }
        public int Age { get; set; }

        public void SetAge(string age)
        {
            int temp = int.Parse(age);
            Age = temp;
        }
    }
}
