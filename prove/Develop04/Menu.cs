using System;
using static System.Console;

namespace Mindfulness
{
    class Menu
    {
        private string _choice;

        public Menu()
        {
            
        }


        public void MenuItem()
        {
            
            do
            {        
                _choice = GetChoice();
                string activityName = "";
                //int activityTime;
                switch (_choice)
                {
                    case "1":
                        //Start Breathing Activity
                        activityName = "Breathing Activity";
                        // activityTime = RequestActivityDuration();
                        string breathDescription = "This activity will help you relax by walking you through breathing in and out \nslowly. Clear your mind and focus on your breathing.";
                        Activity breathe = new Activity(activityName, breathDescription);
                        breathe.RunActivity();                      
                        break;

                    case "2":
                        //Start Reflection Activity
                        activityName = "Reflection Activity";
                        //activityTime = RequestActivityDuration();
                        string reflectDescription = "This activity will help you reflect on times in your life when you have had the \nopportunity to show strength and resilience. This will help you recognize the power you have and \nhow you can use it in other aspects of your life.";
                        Activity reflect = new Activity(activityName, reflectDescription);
                        reflect.RunActivity();                      
                        break;

                    case "3":
                        //Start Listing Activitiy
                        activityName = "Listing Activity";
                        //activityTime = RequestActivityDuration();
                        string listingDescription = "This activity will help you reflect on the good things in your life by having you \nlist as many things as you can in a certain area.";
                        Activity list = new Activity(activityName, listingDescription);
                        list.RunActivity();                      
                        break;

                    case "4":
                        //Start Naming Activity
                        activityName = "Grounding Activity";
                        //activityTime = RequestActivityDuration();
                        string groundDescription = "When you take the time to name things you can hear, see, and feel, you are grounding \nyourself by increasing your awareness of your body and your environment.";
                        Activity ground = new Activity(activityName, groundDescription);
                        ground.RunActivity();
                        break;
                    
                    default:
                        break;
                }
            } while (_choice != "5");
        }

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
                
                Write("\nChoice: ");
                _choice = ReadLine();
                WriteLine("\n~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~");


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

        // public int RequestActivityDuration()
        // {
        //     Write("\nEnter number of seconds you want to spend on this activity (example: 45): ");
        //     int activityTime = int.Parse(ReadLine());
        //     Clear();

        //     return activityTime;
        // }
        
    }

      

    

}