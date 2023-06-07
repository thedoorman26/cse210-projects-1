using System;
using static System.Console;

namespace Mindfulness
{
    class Activity
    {
        protected string _activityName;
        protected string _description;
        protected int _activityTime;

        public Activity()
        {

        }
        public Activity(string activity, string description)
        {
            _activityName = activity;
            _description = description;

        }

        public void RunActivity()
        {
            DisplayActivityStart();      

            if (_activityName == "Breathing Activity")
            {
                BreathingActivity breath = new BreathingActivity(_activityName, _description);
                breath.RunBreath();

            } else if (_activityName == "Reflection Activity")
            {
                ReflectionActivity reflect = new ReflectionActivity(_activityName, _description);
                reflect.RunReflection();

            } else if (_activityName == "Listing Activity")
            {
                ListingActivity list = new ListingActivity(_activityName, _description);
                list.RunListing();
                
            } else if (_activityName == "Grounding Activity")
            {
                GroundingActivity ground = new GroundingActivity(_activityName, _description);
                ground.RunGrounding();
            }

            DisplayActivityClose();
        }
        public void DisplayActivityStart()
        {
            Clear();
            ForegroundColor = ConsoleColor.Yellow;
            WriteLine("\n^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^");
            WriteLine(($"\t*****  Welcome to the {_activityName}.  *****"));
            Write("\nDescription: ");
            for (int i = 0; i < _description.Length; i++)
            {
                Write(_description[i]);
                Thread.Sleep(10);
            }
            //WriteLine(($"\n\nYou have choosen to practice for {_activityTime} seconds."));
            WriteLine("\n\n^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^");
            ForegroundColor = ConsoleColor.Blue;           
        }

        public void DisplayActivityClose()
        {
            PauseTime("Ending");
            ForegroundColor = ConsoleColor.Yellow;
            WriteLine("\n^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^");
            WriteLine(($"\nThank you for participating in the {_activityName} for {_activityTime} seconds. Practicing Mindfulness is \na healthy thing to do!"));
            WriteLine("\n^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^");
            ForegroundColor = ConsoleColor.Blue;
            WriteLine("\nPress any key to return to the menu...\n");
            ReadKey();
        }

        public int RequestActivityDuration()
        {
            Write("\nEnter number of seconds you want to spend on this activity (example: 45): ");
            _activityTime = int.Parse(ReadLine());

            return _activityTime;
        }

        public DateTime SetTimeDuration()
        {
            DateTime startTime = DateTime.Now;
            DateTime endTime = startTime.AddSeconds((_activityTime));

            return endTime;
        }

        public void CountDown(int n)
        {
            ForegroundColor = ConsoleColor.DarkRed;
            for (int i=n; i >0; i--)
            {
                Write(i);
                Thread.Sleep(1000);
                Write("\b \b");
            }
            ForegroundColor = ConsoleColor.Blue;
        }

        public void PauseTime(string phrase)
        {
            string [] animationStrings = {"|", "/", "-", "\\", "|", "/", "-", "\\", ""};         

            ForegroundColor = ConsoleColor.DarkRed;
            Write($"\n{phrase}... ");
            foreach (string animate in animationStrings)
            {
                Write($"\b \b{animate}");
                Thread.Sleep(400);    
            }
            ForegroundColor = ConsoleColor.Blue;
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