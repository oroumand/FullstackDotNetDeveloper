using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OopAdvanced.ExtensionSamples.Extensions
{
    public static class PersonExtensions
    {
        public static void PrintFullName(this Person person)
        {
            Console.WriteLine($"{person.Id} {person.Name}");
        }
    }
}
