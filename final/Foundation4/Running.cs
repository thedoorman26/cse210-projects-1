using System;
using System.IO;
using System.Collections.Generic;
using static System.Console;
using System.Text;

namespace Foundation4
{
    class Running : Activity
    {
        //Private attribute for the running class
        private int _distance;


        //Constructor for the running class
        public Running(DateTime date, int minutes, int distance) :base(date, minutes)
        {
            _distance = distance;
        }


        //Method to overwrite the calculate distance method and return the distance
        public override double CalculateDistance()
        {
            return _distance;
        }


        //Method to overwrite the calculate speed method
        public override double CalculateSpeed()
        {
            double speed = (CalculateDistance() / _minutes) * 60;
            double formatSpeed = double.Parse(speed.ToString("0.00"));
            return formatSpeed;
        }
    }
}