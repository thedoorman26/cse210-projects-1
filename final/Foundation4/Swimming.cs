using System;
using System.IO;
using System.Collections.Generic;
using static System.Console;
using System.Text;

namespace Foundation4
{
    //
    class Swimming : Activity
    {
        //Private attributes for the swimming class
        private double _laps;
        private double _lapsDistance;

        //Constructor for the swimming class
        public Swimming(DateTime date, int minutes, int laps) :base(date, minutes)
        {
            _laps = laps;        
        }


        //Method to overwrite the calculate distance method of the activity class
        public override double CalculateDistance()
        {
            _lapsDistance = _laps * 50 / 1000 * 0.62;
            double swimDistance = double.Parse(_lapsDistance.ToString("0.00"));
            return swimDistance;
        }


        //Method to overwrite the calculate speed method of the activity class
        public override double CalculateSpeed()
        {
            double speed = (CalculateDistance() / _minutes) * 60;
            double formatSpeed = double.Parse(speed.ToString("0.00"));
            return formatSpeed;
        }
    }
}