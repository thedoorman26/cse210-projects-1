using System;
using static System.Console;

namespace Mindfulness
{
    class Activity
    {
        protected string _activityName;
        protected string _description;
        protected int _activityTime;

        public Activity(string activity, string description, int duration)
        {
            _activityName = activity;
            _description = description;
            _activityTime = duration;
        }

        public void RunActivity()
        {
            if (_activityName == "Breathing Activity")
            {
                BreathingActivity breath = new BreathingActivity(_activityName, _description, _activityTime);
                breath.RunBreath();
            }
        }
        public void DisplayActivityStart()
        {
            WriteLine(($"\t*****  Welcome to the {_activityName}.  *****"));
            WriteLine(($"\nDescription: {_description}"));
            WriteLine(($"\nThis activity will last {_activityTime} seconds.\n"));
        }

        public void DisplayActivityClose()
        {
            WriteLine(($"\nThank you for participating in the {_activityName}. Practicing Mindfulness is a healthy thing to do!"));
            WriteLine("\nPress any key to return to the menu...\n");
            ReadKey();
        }

        public void SetTimeDuration()
        {
            DateTime startTime = DateTime.Now;
            DateTime endTime = startTime.AddSeconds((_activityTime * 1000));

            while (DateTime.Now < endTime)
            {
                RunActivity();
            }

        }
        public void CountDown()
        {
            for (int i=6; i >0; i--)
            {
                Write(i);
                Thread.Sleep(1000);
                Write("\b \b");
               // Write("|/-\\|/-\\|");
            }
        }

        public void PauseTime()
        {
            Thread.Sleep(1000);
            Write("|/-\\|/-\\|");
        }

        public void GetRandomIndex()
        {

        }

    }


}