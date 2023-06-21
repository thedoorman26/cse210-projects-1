using System;
using static System.Console;

namespace EternalQuest
{
    class Menu
    {
        string _choice;
        // GoalHandling goal = new GoalHandling(); 
        ListHandling newGoal = new ListHandling();

        public Menu()
        {
            
        }

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
                        WriteLine("\nGoals List:");
                        ForegroundColor = ConsoleColor.Blue; 
                        newGoal.ListGoal();                
                        break;

                    case "3":
                        //Save Goals
                        ForegroundColor = ConsoleColor.DarkRed;
                        WriteLine("\nSave Goals");
                        Thread.Sleep(1000);
                        newGoal.SaveGoal();
                        WriteLine("Your goals have been saved!");
                        ForegroundColor = ConsoleColor.Blue;
                                  
                        break;

                    case "4":
                        //Load Goals
                        ForegroundColor = ConsoleColor.DarkRed;
                        WriteLine("\nLoading Goals");  
                        newGoal.LoadGoal();
                        Thread.Sleep(1000);
                        ForegroundColor = ConsoleColor.DarkRed;
                        WriteLine("Goal file Loaded!  Please choose 'List Goals' from the main menu to see the list of goals."); 
                        ForegroundColor = ConsoleColor.Blue;              
                        break;

                    case "5":
                        //Record Event
                        ForegroundColor = ConsoleColor.DarkRed;
                        WriteLine("\nRecord Event");
                        ForegroundColor = ConsoleColor.Blue;                 
                        break;                    
                    
                    default:
                        break;
                }

                ForegroundColor = ConsoleColor.Gray;
                Write("Press any key to return to the main menu...");
                ReadKey();
                ForegroundColor = ConsoleColor.Blue;

            } while (_choice != "6");
            

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
                WriteLine($"\nYou have {newGoal.GetPoints()} points.");
                ForegroundColor = ConsoleColor.Blue;
                WriteLine("\nWhat would you like to do in the Eternal Quest Program?");
                WriteLine("\n1. Create New Goal");
                WriteLine("2. List Goals");
                WriteLine("3. Save Goals");
                WriteLine("4. Load Goals");
                WriteLine("5. Record Event");
                WriteLine("6. Quit");
                WriteLine("\n*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*");
                
                ForegroundColor = ConsoleColor.DarkRed;
                Write("\nEnter your choice: ");
                ForegroundColor = ConsoleColor.Blue;
                _choice = ReadLine();
                


                //This section is to verify that the choice was actually correct and avoids user error problems.
                if (_choice == "1" || _choice == "2" || _choice == "3" || _choice == "4" || _choice == "5" || _choice == "6")
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

        public void SubMenu()
        {
            
            string type = "";
            WriteLine("\n*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*");
            WriteLine("\nWhat kind of goal would you like to make?");
            WriteLine("\n1. Simple Goal");
            WriteLine("2. Checklist Goal");
            WriteLine("3. Eternal Goal");
            WriteLine("\n*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*");
            
            ForegroundColor = ConsoleColor.DarkRed;
            Write("\nEnter your choice: ");
            ForegroundColor = ConsoleColor.Blue;
            string goalChoice = ReadLine();
            

            //This section is to verify that the choice was actually correct and avoids user error problems.
            if (goalChoice == "1")
            {
                WriteLine("Choice 1");
                type = "Simple Goal";
                newGoal.SetGoal(type);
            } 
            else if (goalChoice == "2")  
            {
                WriteLine("Choice 2");
                type = "Checklist Goal";
                newGoal.SetGoal(type);
            } 
            else if (goalChoice == "3")
            {
                WriteLine("Choice 3");
                type = "Eternal Goal";
                newGoal.SetGoal(type);
            }
            else  WriteLine($"\n'{goalChoice}' is not an available choice. Try Again.");
           
        }

    }
}