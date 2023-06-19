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
                        WriteLine("List Goals"); 
                        newGoal.ListGoal();                
                        break;

                    case "3":
                        //Save Goals
                        WriteLine("Save Goals");
                        newGoal.SaveGoal();
                                  
                        break;

                    case "4":
                        //Load Goals
                        WriteLine("Load Goals");                 
                        break;

                    case "5":
                        //Record Event
                        WriteLine("Record Event");                 
                        break;                    
                    
                    default:
                        break;
                }
                Write("Press any key to return to the main menu...");
                ReadKey();
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
                WriteLine($"\nYou have {newGoal.GetPoints()} points.");
                WriteLine("\nWhat would you like to do in the Eternal Quest Program?");
                WriteLine("\n1. Create New Goal");
                WriteLine("2. List Goals");
                WriteLine("3. Save Goals");
                WriteLine("4. Load Goals");
                WriteLine("5. Record Event");
                WriteLine("6. Quit");
                WriteLine("\n*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*");
                
                Write("\nEnter your choice: ");
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
            
            Write("\nEnter your choice: ");
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