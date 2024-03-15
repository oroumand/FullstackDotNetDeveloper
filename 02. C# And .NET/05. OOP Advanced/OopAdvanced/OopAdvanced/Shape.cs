using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopAdvanced
{

    public class UseShapes
    {

        public void Use()
        {
            List<Shape> shapes = new List<Shape>();
            List<FourSquare> fourSquares = new List<FourSquare>();
            List<NoSquar> noSquars = new List<NoSquar>();

            Shape shape = new Shape();

            shapes.Add(shape);
            //fourSquares.Add(shape);

            FourSquare fourSquare = new FourSquare();
            shapes.Add(fourSquare);
            fourSquares.Add(fourSquare);
            //noSquars.Add(fourSquare);

            Rectangle rectangle = new Rectangle();
            shapes.Add(rectangle);
        }
    }
    public class Shape
    {
        public virtual string SayName() => "Shape";
    }

    public class FourSquare:Shape
    {
        public override string SayName()
        {
            return "FourSquare";
        }
    }


    public class Square : FourSquare {
    
    }
    public class Rectangle:FourSquare {
    }


    public class NoSquar: Shape
    {

        public override string SayName()
        {
            return "NoSquar";
        }
    }
    public class  Circle:NoSquar
    {
        
    }
    public class Ellipse : NoSquar
    {

    }

    public class SampleClass:FourSquare,NoSquar
    {

    }
}
