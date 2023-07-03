using System;
using System.IO;
using System.Collections.Generic;
using static System.Console;
using System.Text;

namespace Foundation4
{
    class Swimming : Activity
    {
         double _laps {get; set;}
         double _lapsDistance {get; set;}

        public Swimming(DateTime date, int minutes, int laps, int distance) :base(date, minutes)
        {


        }

        public override double CalculateDistance()
        {
            //distance in miles
            _lapsDistance = _laps * 50 / 1000 * 0.62;
            return _lapsDistance;
        }

        public override double CalculateSpeed()
        {
            double speed = 60 / CalculatePace();
            return speed;
        }

        public override double CalculatePace()
        {
            double pace = _lapsDistance / _minutes;
            return pace;
        }

        // public override string GetSummary()
        // {
        //     return "";
        // }
    }
}