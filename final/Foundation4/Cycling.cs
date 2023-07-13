using System;
using System.IO;
using System.Collections.Generic;
using static System.Console;
using System.Text;

namespace Foundation4
{
    class Cycling : Activity
    {
        //Private attribute for the cycling class
        private double _speed;


        //Constructor for the cycling class
        public Cycling(DateTime date, int minutes, double speed) :base(date, minutes)
        {
            _speed = speed;
        }


        //Overwritten method to calculate distance
        public override double CalculateDistance()
        {
            double distance = (_speed * _minutes) / 60;
            double formatDistance = double.Parse(distance.ToString("0.00"));
            return formatDistance;
        }


        //Overwritten method to return speed
        public override double CalculateSpeed()
        {
            return _speed;
        }

    }
}
