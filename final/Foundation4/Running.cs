using System;
using System.IO;
using System.Collections.Generic;
using static System.Console;
using System.Text;

namespace Foundation4
{
    class Running : Activity
    {
        int _distance {get; set;}

        public Running(DateTime date, int minutes, int distance) :base(date, minutes)
        {
            _distance = distance;
        }

        public override double CalculateDistance()
        {
            return _distance;
        }

        public override double CalculateSpeed()
        {
            double speed = _distance / _minutes * 60;
            return speed;
        }

        public override double CalculatePace()
        {
            double pace = _minutes / _distance;
            return pace;
        }

        // public override string GetSummary()
        // {
        //     return "";
        // }
    }
}