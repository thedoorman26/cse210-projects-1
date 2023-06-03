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


        public void MenuAction()
        {
            
            do
            {        
                _choice = GetChoice();
                string activityName = "";
                int activityTime;
                switch (_choice)
                {
                    case "1":
                        //Start Breathing Activity
                        activityName = "Breathing Activity";
                        activityTime = RequestActivityDuration();
                        string breathDescription = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
                        Activity breathe = new Activity(activityName, breathDescription, activityTime);
                        breathe.SetTimeDuration();                      
                        break;

                    case "2":
                        //Start Reflection Activity
                        activityName = "Reflection Activity";
                        activityTime = RequestActivityDuration();
                        string reflectDescription = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
                        Activity reflect = new Activity(activityName, reflectDescription, activityTime);
                        reflect.SetTimeDuration();                      
                        break;

                    case "3":
                        //Start Listing Activitiy
                        activityName = "Listing Activity";
                        activityTime = RequestActivityDuration();
                        string listingDescription = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
                        Activity list = new Activity(activityName, listingDescription, activityTime);
                        list.SetTimeDuration();                      
                        break;

                    case "4":
                        //Start Naming Activity
                        activityName = "Naming Activity";
                        activityTime = RequestActivityDuration();
                        string groundDescription = "When you take the time to name things you can hear, see, and feel, you are grounding yourself by increasing your awareness of your body and your environment.";
                        Activity ground = new Activity(activityName, groundDescription, activityTime);
                        ground.SetTimeDuration();
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
                WriteLine("\nPlease select a Mindfulness Activity.");
                WriteLine("\n1. Start Breathing Activity");
                WriteLine("2. Start Reflecting Activity");
                WriteLine("3. Start Listing Activity");
                WriteLine("4. Start Grounding Activity");
                WriteLine("5. Quit");
                
                Write("\nChoice: ");
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

        public int RequestActivityDuration()
        {
            Write("\nEnter number of seconds you want to spend on this activity (example: 45): ");
            int activityTime = int.Parse(ReadLine());
            WriteLine("");
            return activityTime;
        }
        
    }

      

    

}