using System;
using System.IO;
using System.Collections.Generic;
using static System.Console;
using System.Text;

namespace Foundation4
{
    public abstract class Activity
    {
        //Date and minutes attributes that are used in child classes
        DateTime _date;
        protected int _minutes;


        //Constructors for attributes that are instantiated
        public Activity(DateTime date, int minutes)
        {
            _date = date;
            _minutes = minutes;
        }

        
        //Method to calculate Pace.  Method is able to be used for all child classes in this program
        public double CalculatePace()
        {
            double pace = _minutes / CalculateDistance();
            double formatPace = double.Parse(pace.ToString("0.00"));
            return formatPace;
        }


        //Summary display method.  Also able to be used for all child classes in this program
        public virtual string GetSummary()
        {
            string formatDate = _date.ToString("dd MMM yyyy");
            string summary = ($"\n{formatDate} {GetType().Name} ({_minutes} min)- Distance: {CalculateDistance()} miles, Speed: {CalculateSpeed()} mph, Pace: {CalculatePace()} min per mile");
            return summary;
        }
        

        //Abstract methods that are overwritten in the child classes
        public abstract double CalculateDistance();
        public abstract double CalculateSpeed();
    }
}