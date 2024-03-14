using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopAdvanced.WhyPolymorphe
{
    public class Pizza
    {
        List<Ingrediant> Ingrediants = new List<Ingrediant>();

        public void Add(Ingrediant Ingrediant)
        {

        }

        public void PrintOnScreen()
        {
            foreach (var Ingrediant in Ingrediants)
            {
                Console.WriteLine();
            }
        }

    }
    public class Ingrediant
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageURL { get; set; }
    }
    public class Cheez: Ingrediant
    {


        public int Hdd { get; set; }
        public int Ram { get; set; }
        public int MonitorSize { get; set; }
    }

    public class Tomato: Ingrediant
    {

        public string Author { get; set; }
        public int PageCount { get; set; }
        public string ISBN { get; set; }
    }

    public class Potato: Ingrediant
    {

        public int WheelsCount { get; set; }
        public int DoorCount { get; set; }
    }
}
