using System;
using static System.Console;

namespace Mindfulness
{
    class Activity
    {
        //Private variables to hold activity details that are passed into Activity
        protected string _activityName;
        protected string _description;
        private int _activityTime;

        public Activity()
        {

        }

        //Constructor to hold the common variables for the classes.
        public Activity(string activity, string description)
        {
            _activityName = activity;
            _description = description;
        }


        //Method for running each of the activities that can be picked from the menu.
        public void RunActivity()
        {
            //Start Message
            DisplayActivityStart(); 


            //Allow user to set the activity time
            _activityTime = RequestActivityDuration();


            //Starts activity based on the name sent from the menu class
            if (_activityName == "Breathing Activity")
            {
                BreathingActivity breath = new BreathingActivity(_activityName, _description); 
                ActivityTimeLoop(() => breath.DisplayBreath());
            } 
            
            else if (_activityName == "Reflection Activity")
            {   
                ReflectionActivity reflect = new ReflectionActivity(_activityName, _description);            
                reflect.DisplayReflectionPrompt();
                ActivityTimeLoop(() => reflect.PonderQuestions());
            } 
            
            else if (_activityName == "Listing Activity")
            { 
                ListingActivity list = new ListingActivity(_activityName, _description);
                list.DisplayListingPrompt();
                ActivityTimeLoop(() => list.KeepListing());
                list.ListedItemsCount();
            } 
            
            else if (_activityName == "Grounding Activity")
            {
                GroundingActivity ground = new GroundingActivity(_activityName, _description);
                ActivityTimeLoop(() => ground.PromptGrounding());
                ground.DisplayGrounding();
            }
            
            //Closing message
            DisplayActivityClose();
        }
        

        //Activity start message uses variables so each activity start the same.
        private void DisplayActivityStart()
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
        private void DisplayActivityClose()
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
        private int RequestActivityDuration()
        {
            bool properNumber = false;

            do
            {
                Write("\nEnter number of seconds you want to spend on this activity (example: 45): ");
                string userInput  = ReadLine();
                
                if (IsPositiveWholeNumber(userInput))
                {
                    _activityTime = int.Parse(userInput);
                    properNumber = true;
                }
                else
                {
                    WriteLine($"Input '{userInput}' is not a valid number for seconds, please try again.");
                    properNumber = false;
                }                            
            } while (!properNumber);

            return _activityTime;
        }

        private bool IsPositiveWholeNumber(string userInput)
        {
            if (int.TryParse(userInput, out int number))
            {
                if (number > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }                
            }
            else
            {
                return false;
            }
        }


        //Uses the DateTime class to get time and return the endTime to the activity
        private DateTime SetTimeDuration()
        {
            DateTime startTime = DateTime.Now;
            DateTime endTime = startTime.AddSeconds((_activityTime));

            return endTime;
        }


        //This method creates a loop with a set endTime and passes in the activity method 
        private void ActivityTimeLoop(Action action)
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