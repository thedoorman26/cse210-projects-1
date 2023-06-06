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
                breath.RunBreath(SetTimeDuration());

            } else if (_activityName == "Reflection Activity")
            {
                ReflectionActivity reflect = new ReflectionActivity(_activityName, _description, _activityTime);
                reflect.RunReflection(SetTimeDuration());

            } else if (_activityName == "Listing Activity")
            {
                ListingActivity list = new ListingActivity(_activityName, _description, _activityTime);
                list.RunListing(SetTimeDuration());
                
            } else if (_activityName == "Grounding Activity")
            {
                GroundingActivity ground = new GroundingActivity(_activityName, _description, _activityTime);
                ground.RunGrounding(SetTimeDuration());
            }
        }
        public void DisplayActivityStart()
        {
            ForegroundColor = ConsoleColor.Yellow;
            WriteLine("\n~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~");
            WriteLine(($"\t*****  Welcome to the {_activityName}.  *****"));
            WriteLine(($"\nDescription: {_description}"));
            WriteLine(($"\nThis activity will last {_activityTime} seconds."));
            WriteLine("\n~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~");
            ForegroundColor = ConsoleColor.Blue;
            Write("Get Ready...");
            PauseTime();
            WriteLine("");

        }

        public void DisplayActivityClose()
        {
            PauseTime();
            ForegroundColor = ConsoleColor.Yellow;
            WriteLine("\n~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~");
            WriteLine(($"\nThank you for participating in the {_activityName}. Practicing Mindfulness is a healthy thing to do!"));
            WriteLine("\n~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~");
            ForegroundColor = ConsoleColor.Blue;
            WriteLine("\nPress any key to return to the menu...\n");
            ReadKey();
        }

        public DateTime SetTimeDuration()
        {
            DateTime startTime = DateTime.Now;
            DateTime endTime = startTime.AddSeconds((_activityTime));

            return endTime;
        }


        public void CountDown()
        {
            ForegroundColor = ConsoleColor.DarkRed;
            for (int i=6; i >0; i--)
            {
                Write(i);
                Thread.Sleep(1000);
                Write("\b \b");
            }
            ForegroundColor = ConsoleColor.Blue;
        }

        public void PauseTime()
        {
            ForegroundColor = ConsoleColor.DarkRed;
            Write("\b \b|");
            Thread.Sleep(1000);
            Write("\b \b/");
            Thread.Sleep(1000);
            Write("\b \b-");
            Thread.Sleep(1000);
            Write("\b \b\\");
            Thread.Sleep(1000);
            Write("\b \b|");
            Thread.Sleep(1000);
            Write("\b \b");
            ForegroundColor = ConsoleColor.Blue;
            //Write("|/-\\|/-\\|");
        }

        public int GetRandomPromptIndex(int listCount)
        {
            int randomIndex;
            Random rand = new Random();
            randomIndex = rand.Next(0, listCount);
            return randomIndex;
        }

    }


}