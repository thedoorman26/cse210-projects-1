using System;
using static System.Console;

namespace Mindfulness
{
    class Activity
    {
        protected string _activityName;
        protected string _description;
        protected int _timer;

        public Activity(string activity, string description, int time)
        {
            _activityName = activity;
            _description = description;
            _timer = time;
        }

        public void DisplayActivityStart()
        {
            WriteLine(($"\t*****  Welcome to the {_activityName}.  *****"));
            WriteLine(($"\nDescription: {_description}"));
            WriteLine(($"\nThis activity will last {_timer} seconds.\n"));
        }

        public void DisplayActivityClose()
        {
            WriteLine(($"\nThank you for participating in the {_activityName}. Practicing Mindfulness is a healthy thing to do!"));
            WriteLine("\nPress any key to return to the menu...\n");
            ReadKey();
        }

        public void TrackTime()
        {

        }

        public void PauseTime()
        {
            
        }

        public void GetRandomIndex()
        {

        }

    }


}