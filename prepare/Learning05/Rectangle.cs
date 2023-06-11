using System;
using static System.Console;

namespace ShapesArea
{
    class Rectangle : Shape
    {
        private double _lenth;
        private double _width;

        public Rectangle(string color, double length, double width) : base(color)
        {

        }

        public override double GetArea()
        {
            return -1;
        }
    }
}