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


        public void MenuAction(string choice)
        {
            string _choice = "";

                        
            do
            {        
                _choice = choice;
                string activityName = "";
                int activityTime = 1000;
                // string date = FindDate();
                // string rPrompt = RetrievePrompt();
                switch (_choice)
                {
                    case "1":
                        //Start Breathing Activity
                        WriteLine("You choose the Breathing Activity");
                        activityName = "Breathing Activity";
                        string breathDescription = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
                        Activity breathe = new Activity(activityName, breathDescription, activityTime);
                        breathe.RunActivity();                      
                        break;

                    case "2":
                        //Start Reflection Activity
                        WriteLine("You choose the Reflection Activity"); 
                        activityName = "Reflection Activity";
                        string reflectDescription = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
                        Activity reflect = new Activity(activityName, reflectDescription, activityTime);
                        reflect.RunActivity();                      
                        break;

                    case "3":
                        //Start Listing Activitiy
                        WriteLine("You choose the Lisitng Activity");                       
                        break;

                    case "4":
                        //Start Naming Activity
                        WriteLine("You choose the Naming Activity.");
                        break;
                    
                    default:
                        break;
                }
            } while (_choice != "5");
        }

        public string GetChoice()
        {
            _choice = "";
            bool properChoice = false;

            do
            {
                //Menu choices for the user.
                WriteLine("\nPlease select a Mindfulness Activity.");
                WriteLine("\n1. Start Breathing Activity");
                WriteLine("2. Start Reflecting Activity");
                WriteLine("3. Start Listing Activity");
                WriteLine("4. Start Naming Activity");
                WriteLine("5. Quit");
                
                Write("\nChoice: ");
                _choice = ReadLine();

                //This section is to verify that the choice was actually correct and avoids user error problems.
                if (_choice == "1" || _choice == "2" || _choice == "3" || _choice == "4")
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