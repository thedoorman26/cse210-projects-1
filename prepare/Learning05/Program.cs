using System;

namespace ShapesArea
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape newShape = new Shape("");
            
            Square newSquare = new Square("green", 5);
            newSquare.RunShape();
        }
    }
}