using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopAdvanced.WhyPolymorphe
{
    public class Zoo
    {
        List<Animal> AnimalInZoo = [];

        public void AddAnimal(Animal animal)
        {
            AnimalInZoo.Add(animal);
        }

        public void PrintOnScreen()
        {
            foreach (var product in propducts)
            {
                Console.WriteLine();
            }
        }

    }

    public class Animal
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageURL { get; set; }
    }
    public class Cat:Animal
    {

    }

    public class Dog : Animal
    {


    }

    public class Horse : Animal
    {


    }
}
