using System;
using System.IO;
using System.Collections.Generic;
using static System.Console;
using System.Text;

namespace Foundation4
{
    class Cycling : Activity
    {
        double _speed {get; set;}

        public Cycling(DateTime date, int minutes, double speed) :base(date, minutes)
        {

        }

        public override double CalculateDistance()
        {
            double distance = (_speed * _minutes) / 60;
            return distance;
        }

        public override double CalculateSpeed()
        {
            return _speed;
        }

        public override double CalculatePace()
        {
            return 60 / _speed;
        }

        // public override string GetSummary()
        // {
        //     return "";
        // }
    }
}