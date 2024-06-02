using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqSamples.AverageSamples
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int FatherName { get; set; }

        public static List<Person> GetList()
        {
            return [
                new Person { Age = 100, Name = "Alrieza" },
                new Person { Age = 10, Name = "Hassan" },
                new Person { Age = 110, Name = "Hossein" },
                new Person { Age = 100, Name = "Mohammad" },
                new Person { Age = 100, Name = "Farid" },
                new Person { Age = 110, Name = "Masoud" },
                new Person { Age = 20, Name = "Reza" },
            ];
        }
    }
}
