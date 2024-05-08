using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionSamples.StackTraceSample
{
    public  class PersonController
    {
        public void CreatePerson(string firstName,string age)
        {
            Person person = new();
            person.FirstName = firstName;
            person.SetAge(age);

        }
    }
}
