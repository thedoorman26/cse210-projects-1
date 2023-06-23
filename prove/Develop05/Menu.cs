using System;
using static System.Console;

namespace EternalQuest
{
    class Menu
    {
        //Private variable for the Menu class, and instantiation for the ListHandling class the Menu calls on
        private string _choice;
        ListHandling newGoal = new ListHandling();

        //Empt constructor for Program to call on Menu
        public Menu()
        {
            
        }

        //Method to process the user choice from the main menu.  Calls on ListHandling methods to process requests
        public void MenuItem()
        {         
            //GoalHandling goal = new GoalHandling();   
            do
            {        
                _choice = GetChoice();
                switch (_choice)
                {
                    case "1":
                        //Create New Goal
                        SubMenu();

                        break;

                    case "2":
                        //List Goals
                        ForegroundColor = ConsoleColor.DarkRed;
                        WriteLine("\nGoals List:\n");
                        ForegroundColor = ConsoleColor.Blue; 
                        newGoal.ListGoal();    
                                    
                        break;

                    case "3":
                        //Save Goals
                        ForegroundColor = ConsoleColor.DarkRed;
                        WriteLine("\nSave Goals");
                        Thread.Sleep(1000);
                        newGoal.SaveGoal();
                        ForegroundColor = ConsoleColor.DarkRed;
                        WriteLine("\nYour goals have been saved!");
                        ForegroundColor = ConsoleColor.Blue;
                                  
                        break;

                    case "4":
                        //Load Goals
                        ForegroundColor = ConsoleColor.DarkRed;
                        WriteLine("\nLoading Goals");  
                        newGoal.LoadGoal();
                        Thread.Sleep(1000);
                        ForegroundColor = ConsoleColor.DarkRed;
                        WriteLine("\nGoal file Loaded!  Please choose 'List Goals' from the main menu to see the list of goals."); 
                        ForegroundColor = ConsoleColor.Blue; 

                        break;

                    case "5":
                        //Record Event
                        ForegroundColor = ConsoleColor.DarkRed;
                        WriteLine("\nRecord Event");
                        newGoal.UserRecordEvent();
                        Thread.Sleep(1000);
                        ForegroundColor = ConsoleColor.Blue;
                                        
                        break;
                    
                    case "6":
                        //Remove an object from the list
                        ForegroundColor = ConsoleColor.DarkRed;
                        WriteLine("\nRemove a Goal\n");
                        newGoal.RemoveGoal();
                        Thread.Sleep(1000);
                        WriteLine("\nGoal Removed.");
                        ForegroundColor = ConsoleColor.Blue;

                        break;

                    default:
                        break;
                }

                //Wait for key to be pressed, helps make sure menu messages get to be seen
                ForegroundColor = ConsoleColor.Gray;
                Write("\nPress any key to continue...");
                ReadKey();
                ForegroundColor = ConsoleColor.Blue;

            } while (_choice != "7");
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
                WriteLine("\n*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*");
                ForegroundColor = ConsoleColor.DarkRed;
                WriteLine($"\nYou have {newGoal._totalPoints} points.");
                ForegroundColor = ConsoleColor.Blue;
                WriteLine("\nWhat would you like to do in the Eternal Quest Program?");
                WriteLine("\n1. Create New Goal");
                WriteLine("2. List Goals");
                WriteLine("3. Save Goals");
                WriteLine("4. Load Goals");
                WriteLine("5. Record Event");
                WriteLine("6. Remove a Goal");
                WriteLine("7. Quit");
                WriteLine("\n*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*");
                

                //Wait for key to be pressed, helps make sure menu messages get to be seen
                ForegroundColor = ConsoleColor.DarkRed;
                Write("\nEnter your choice: ");
                ForegroundColor = ConsoleColor.Blue;
                _choice = ReadLine();
                


                //This section is to verify that the choice was actually correct and avoids user error problems.
                if (_choice == "1" || _choice == "2" || _choice == "3" || _choice == "4" || _choice == "5" || _choice == "6" || _choice == "7")
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


        //This is a secondary menu that appears for Choice 1 so the user can create a goal
        public void SubMenu()
        {            
            string type = "";
            WriteLine("\n*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*");
            WriteLine("\nWhat kind of goal would you like to make?");
            WriteLine("\n1. Simple Goal");
            WriteLine("2. Checklist Goal");
            WriteLine("3. Eternal Goal");
            WriteLine("\n*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*");
            

            
            //Wait for key to be pressed, helps make sure menu messages get to be seen
            ForegroundColor = ConsoleColor.DarkRed;
            Write("\nEnter your choice: ");
            ForegroundColor = ConsoleColor.Blue;
            string goalChoice = ReadLine();
            

            //This section is to verify that the choice was actually correct and avoids user error problems, also calls method to set goals
            if (goalChoice == "1")
            {
                WriteLine("Simple Goal");
                type = "Simple Goal";
                newGoal.SetGoal(type);
            } 
            else if (goalChoice == "2")  
            {
                WriteLine("Checklist Goal");
                type = "Checklist Goal";
                newGoal.SetGoal(type);
            } 
            else if (goalChoice == "3")
            {
                WriteLine("Eternal Goal");
                type = "Eternal Goal";
                newGoal.SetGoal(type);
            }
            else  WriteLine($"\n'{goalChoice}' is not an available choice. Try Again.");
           
        }

    }
}