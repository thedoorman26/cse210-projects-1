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
            WriteLine(($"Welcome to the {_activityName}.  {_description}\nThis activity will last {_timer}ms."));
        }

        public void DisplayActivityClose()
        {
            WriteLine(($"Thank you for participating in the {_activityName}. Practicing Mindfulness is a healthy thing to do!"));
            WriteLine("Press any key to exit");
            ReadKey();
        }

        public void GetRandomIndex()
        {

        }

        public void RunActivity()
        {
            DisplayActivityStart();
            DisplayActivityClose();
        }
    }


}