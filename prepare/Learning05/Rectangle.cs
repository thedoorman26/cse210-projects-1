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
            _lenth = length;
            _width = width;
        }

        public override double GetArea()
        {
            return _lenth * _width;
        }

        public void DisplayRectangle()
        {
           WriteLine($"The rectangle is {GetColor()} with an area of {GetArea()}."); 
        }
    }
}