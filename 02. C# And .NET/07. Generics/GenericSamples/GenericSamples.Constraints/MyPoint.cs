using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace GenericSamples.Constraints
{
    public class MyPoint
    {
        public int X { get; set; }
        public int Y { get; set; }
        public MyPoint()
        {

        }
        public MyPoint(int x, int y)
        {
            X = x;
            Y = y;
        }
    }

    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }

    public class Student : Person
    {
        public string StudentNumber { get; set; }
    }

    public class Teacher : Person, MyInterface
    {
        public string TeacehrNumber { get; set; }

        public void PrintMe()
        {
            Console.WriteLine($"{TeacehrNumber}");
        }
    }
}
