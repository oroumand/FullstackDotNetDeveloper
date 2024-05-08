using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionSamples.Rethrow
{
    public class PersonController
    {
        public void CreatePerson(string firstName, string age)
        {
            //Person person = new();
            //person.FirstName = firstName;
            //person.SetAge(age);
            try
            {
                Person person = new();
                person.FirstName = firstName;
                person.SetAge(age);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Badness!!!");
                throw ex;
                throw new ArgumentException("Bad Arguments Exception", ex);
            }


        }
    }
}
