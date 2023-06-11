using System;
using static System.Console;

namespace ShapesArea
{
    class Square : Shape
    {
        private double _side;

        public Square(string color, double side) : base(color)
        {
            _side = side;
        }

        public override double GetArea()
        {
            return _side * _side;
        }

        
    }
}