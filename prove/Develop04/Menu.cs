using System;
using static System.Console;

namespace Mindfulness
{
    class Menu
    {
        //Private string for the menu class.
        private string _choice;


        //Constructor for the menu class.
        public Menu()
        {
            
        }
        

        //Method for instantiating and starting the activity method to run the selected activity.Takes user choice and passes the right info to the activity class.
        public void MenuItem()
        {            
            do
            {        
                _choice = GetChoice();
                string activityName = "";
                switch (_choice)
                {
                    case "1":
                        //Start Breathing Activity
                        activityName = "Breathing Activity";
                        string breathDescription = "This activity will help you relax by walking you through breathing in and out \nslowly. Clear your mind and get ready to focus on your breathing.";
                        BreathingActivity breathe = new BreathingActivity(activityName, breathDescription);
                        breathe.RunActivity();                      
                        break;

                    case "2":
                        //Start Reflection Activity
                        activityName = "Reflection Activity";
                        string reflectDescription = "This activity will help you reflect on times in your life when you have had the \nopportunity to show strength and resilience. This will help you recognize the power you have and \nhow you can use it in other aspects of your life. Look at the initial prompt and then use the \nfollow up questions to think deeper.";
                        ReflectionActivity reflect = new ReflectionActivity(activityName, reflectDescription);
                        reflect.RunActivity();                      
                        break;

                    case "3":
                        //Start Listing Activitiy
                        activityName = "Listing Activity";
                        string listingDescription = "This activity will help you reflect on the good things in your life by having you \nlist as many things as you can based on a given prompt.";
                        ListingActivity list = new ListingActivity(activityName, listingDescription);
                        list.RunActivity();                      
                        break;

                    case "4":
                        //Start Naming Activity
                        activityName = "Grounding Activity";
                        string groundDescription = "When you take the time to name things you can hear, see, and feel, you are grounding \nyourself by increasing your awareness of your body and your environment.";
                        GroundingActivity ground = new GroundingActivity(activityName, groundDescription);
                        ground.RunActivity();
                        break;
                    
                    default:
                        break;
                }
            } while (_choice != "5");
        }


        //This method contains the prompts for the menu and a way to validate the users choice
        public string GetChoice()
        {
            Clear();
            _choice = "";
            bool properChoice = false;

            do
            {
                //Menu choices for the user.
                WriteLine("\n~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~");
                WriteLine("\nPlease select a Mindfulness Activity.");
                WriteLine("\n1. Breathing Activity");
                WriteLine("2. Reflecting Activity");
                WriteLine("3. Listing Activity");
                WriteLine("4. Grounding Activity");
                WriteLine("5. Quit");
                WriteLine("\n~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~");
                
                Write("\nEnter your choice: ");
                _choice = ReadLine();


                //This section is to verify that the choice was actually correct and avoids user error problems.
                if (_choice == "1" || _choice == "2" || _choice == "3" || _choice == "4" || _choice == "5")
                {
                    properChoice = true;
                }
                else
                {
                    WriteLine($"\n'{_choice}' is not an available choice. Enter another choice.");
                }
            } while (!properChoice);

            return _choice;
        }
        
    }    

}