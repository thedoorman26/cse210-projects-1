using System;
using static System.Console;

namespace ShapesArea
{

    class Circle : Shape
    {
        private double _radius;


        public Circle(string color, double radius) : base(color)
        {

        }

        public override double GetArea()
        {
            return -1;
        }
    }
}