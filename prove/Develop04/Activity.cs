using System;
using static System.Console;

namespace Mindfulness
{
    class Activity
    {
        //Private variable to hold activity details that are passed into Activity
        private string _activityName;
        private string _description;
        private int _activityTime;

        public Activity()
        {

        }

        //Constructor to hold variable details passed in
        public Activity(string activity, string description)
        {
            _activityName = activity;
            _description = description;
        }


        //Method for running each of the activities that can be picked
        public void RunActivity()
        {
            //Instantiate the child classes
            BreathingActivity breath = new BreathingActivity(); 
            ReflectionActivity reflect = new ReflectionActivity();
            ListingActivity list = new ListingActivity();
            GroundingActivity ground = new GroundingActivity();  


            //Start Message
            DisplayActivityStart(); 


            //Allow user to set the activity time
            _activityTime = RequestActivityDuration();


            //Starts activity based on the name set from the menu class
            if (_activityName == "Breathing Activity")
            {
                ActivityTimeLoop(() => breath.DisplayBreath());

            } else if (_activityName == "Reflection Activity")
            {               
                reflect.DisplayReflectionPrompt();
                ActivityTimeLoop(() => reflect.PonderQuestions());

            } else if (_activityName == "Listing Activity")
            { 
                list.DisplayListingPrompt();
                ActivityTimeLoop(() => list.KeepListing());
                list.ListedItemsCount();

            } else if (_activityName == "Grounding Activity")
            {
                ActivityTimeLoop(() => ground.PromptGrounding());
                ground.DisplayGrounding();
            }
            
            //Close message
            DisplayActivityClose();
        }
        

        //Activity start message uses variables so each activity start the same.
        public void DisplayActivityStart()
        {
            Clear();
            ForegroundColor = ConsoleColor.Yellow;
            WriteLine("\n^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^");
            WriteLine(($"\t*****  Welcome to the {_activityName}.  *****"));
            
            //uses a loop to have the description write out slowly for a fun effect
            Write("\nDescription: ");
            for (int i = 0; i < _description.Length; i++)
            {
                Write(_description[i]);
                Thread.Sleep(20);
            }

            WriteLine("\n\n^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^");
            ForegroundColor = ConsoleColor.Blue; 
            PauseTime("Get Ready... ");          
        }


        //Activity close message that displays a common message, the activity name, and duration.
        public void DisplayActivityClose()
        {
            PauseTime("Ending... ");
            ForegroundColor = ConsoleColor.Yellow;
            WriteLine("\n^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^");
            WriteLine(($"\nThank you for participating in the {_activityName} for {_activityTime} seconds. Practicing Mindfulness is \na healthy thing to do!"));
            WriteLine("\n^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^");
            ForegroundColor = ConsoleColor.Blue;
            WriteLine("\nPress any key to return to the menu...\n");
            ReadKey();
        }


        //Asks user to set duration and returns the answer
        public int RequestActivityDuration()
        {
            Write("\nEnter number of seconds you want to spend on this activity (example: 45): ");
            _activityTime = int.Parse(ReadLine());
            WriteLine("");

            return _activityTime;
        }


        //Uses the DateTime class to get time and return the endTime to the activity
        public DateTime SetTimeDuration()
        {
            DateTime startTime = DateTime.Now;
            DateTime endTime = startTime.AddSeconds((_activityTime));

            return endTime;
        }


        //This method creates a loop with a set endTime and passes in the activity method 
        public void ActivityTimeLoop(Action action)
        {                       
            DateTime endTime = SetTimeDuration();

            while (DateTime.Now < endTime)
            {  
                //call class action here
                action.Invoke();
            }
        }


        //Countdown loop that takes a number argument to set the countdown
        public void CountDown(int n)
        {
            ForegroundColor = ConsoleColor.DarkRed;
            for (int i=n; i >0; i--)
            {
                Write(i);
                Thread.Sleep(1000);
                Write("\b\b  \b\b \b");
            }
            ForegroundColor = ConsoleColor.Blue;
        }


        //Method that uses a string of characters to give the illusion of a spinner. 
        //Takes a string as an argument so the spinner can have different messages.
        public void PauseTime(string phrase)
        {
            string [] animationStrings = {"|", "/", "-", "\\", "|", "/", "-", "\\", ""};         

            ForegroundColor = ConsoleColor.DarkRed;
            Write($"\n{phrase}");

            //String loop that displays characters
            foreach (string animate in animationStrings)
            {
                Write($"\b \b{animate}");
                Thread.Sleep(500);    
            }
            ForegroundColor = ConsoleColor.Blue;
        }


        //Generates a random index number based on the lenth of the list passed in.
        public int GetRandomPromptIndex(int listCount)
        {
            int randomIndex;
            Random rand = new Random();
            randomIndex = rand.Next(0, listCount);
            return randomIndex;
        }
    }
}