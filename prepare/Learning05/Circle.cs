using System;
using static System.Console;

namespace ShapesArea
{

    class Circle : Shape
    {
        private double _radius;


        public Circle(string color, double radius) : base(color)
        {
            _radius = radius;
        }

        public override double GetArea()
        {
            return Math.PI * _radius * _radius;
        }

        public void DisplayCircle()
        {
             WriteLine($"The circle is {GetColor()} with an area of {GetArea()}.");
        }
    }
}