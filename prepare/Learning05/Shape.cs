using System;
using static System.Console;

namespace ShapesArea
{
    class Shape
    {
        protected string _color;

        //private string _color { get; set; }
        
        public Shape(string color)
        {
            _color = color;
        }   

        public void RunShape()
        {
            WriteLine("Polymorphism Learning Activity!");
            
            WriteLine($"The square is {_color} with an area of {GetArea()}.");

        }

        public string GetColor()
        {
            return _color;
        }
        public void SetColor(string color)
        {
            _color = color;
        }

        public virtual double GetArea()
        {
            return -1;
        }
        
    }
}