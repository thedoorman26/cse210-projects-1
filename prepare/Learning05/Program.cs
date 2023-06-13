using System;
using static System.Console;

namespace ShapesArea
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> _shapes = new List<Shape>();

            WriteLine("Polymorphism Learning Activity!\n");
          
            Square newSquare = new Square("green", 5);
            _shapes.Add(newSquare);
            newSquare.DisplaySquare();
            WriteLine("");

            Rectangle newRectangel = new Rectangle("red", 5, 7);
            _shapes.Add(newRectangel);
            newRectangel.DisplayRectangle();
            WriteLine("");

            Circle newCircle = new Circle("blue", 12);
            _shapes.Add(newCircle);
            newCircle.DisplayCircle();
            WriteLine("");

            foreach (Shape s in _shapes)
            {
                string color = s.GetColor();
                double area = s.GetArea();

                WriteLine($"The color of the shape is {color} and the area is {area}");
            }
        }
    }
}