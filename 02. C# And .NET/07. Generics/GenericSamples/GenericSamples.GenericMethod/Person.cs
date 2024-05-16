using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericSamples.GenericMethod
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public int Age { get; set; }


        public void Print<T>(T printableObject)
        {
            Console.WriteLine($"The value of my object is {printableObject}");
        }
    }
}
