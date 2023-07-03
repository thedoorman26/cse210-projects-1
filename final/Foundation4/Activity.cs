using System;
using System.IO;
using System.Collections.Generic;
using static System.Console;
using System.Text;

namespace Foundation4
{
    public abstract class Activity
    {
        DateTime _date;
        protected int _minutes;

        public Activity(DateTime date, int minutes)
        {
            _date = date;
            _minutes = minutes;
        }

        public abstract double CalculateDistance();
        public abstract double CalculateSpeed();
        public abstract double CalculatePace();
        public virtual string GetSummary()
        {
            string summary = ($"{_date} {GetType()} ({_minutes} min)- Distance: {CalculateDistance()} miles, Speed: {CalculateSpeed()} mph, Pace: {CalculatePace()} min per mile");
            return summary;
        }
        
    }
}