using System;
using static System.Console;

namespace EternalQuest
{
    class ListHandling
    {
        //Overall points variable to hold the tally for the program.
        public int _totalPoints;
        //The Goal List that is pivotal to the function of the program
        private List<Goal> _goals;


        //Locoal lists that assist in loading data from a file and splitting data to be loaded into Goal List.
        private List<string> _simpleData = new List<string>();
        private List<string> _checkData = new List<string>();
        private List<string> _eternalData = new List<string>();


        //Listhandling Constructor that instantiates the List<Goal>.
        public ListHandling()
        {
            _goals = new List<Goal>();            
        }


        //Method to set goals, instantiate them to their class and add them to Goal List
        public void SetGoal(string category)
        {
            //Common set goal questions
            Clear();
            string type = category;
            ForegroundColor = ConsoleColor.DarkRed;
            Write("\nWhat is the name of your goal?  ");
            ForegroundColor = ConsoleColor.Blue;
            string goalName = ReadLine();
            ForegroundColor = ConsoleColor.DarkRed;
            Write("What is a short description of your goal?  ");
            ForegroundColor = ConsoleColor.Blue;
            string goalDescription = ReadLine();
            ForegroundColor = ConsoleColor.DarkRed;
            Write("What is the amount of points your goal is worth?  ");
            ForegroundColor = ConsoleColor.Blue;
            int goalPoints = int.Parse(ReadLine());

            //Instantiate the Simple Goal set
            if (type == "Simple Goal")
            {                
                SimpleGoal simple = new SimpleGoal(type, goalName, goalDescription, goalPoints);
                _goals.Add(simple);
            }

            //Instantiate the checklist goal set, requires a couple more questions and variables
             else if (category == "Checklist Goal")
            {                        
                ForegroundColor = ConsoleColor.DarkRed;
                Write("\nHow many times does this goal need to be accomplished for a bonus?  ");
                ForegroundColor = ConsoleColor.Blue;
                int repeat = int.Parse(ReadLine());
                ForegroundColor = ConsoleColor.DarkRed;
                Write($"What is the amount of bonus points for repeating the goal {repeat} times?  ");
                ForegroundColor = ConsoleColor.Blue;
                int bonus = int.Parse(ReadLine());

                ChecklistGoal check = new ChecklistGoal(type, goalName, goalDescription, goalPoints, bonus, repeat);
                _goals.Add(check);
            }

            //instantiate the eternal goal set
            else if (category == "Eternal Goal")
            {
                EternalGoal eternal = new EternalGoal(type, goalName, goalDescription, goalPoints);
                _goals.Add(eternal);
            }
        }


        //Method to iterate through the goal list and display the goals
        public void ListGoal()
        {   
            int i = 1;
            foreach (Goal g in _goals)
            {
                WriteLine($"{i}. {g.DisplayGoal()}");
                i += 1;
            }
        }


        //Method to Save goals
        public void SaveGoal()
        {
            string fileName = GetFileName();
            
            File.WriteAllText(fileName, ($"Score:{_totalPoints}\n"));

            foreach (Goal g in _goals)
            {
                string entryData = g.CreatSavedData();
                File.AppendAllText(fileName, entryData);
            }
        }


        //Method to Load a goal file, parse text file into parts, add parts to Goal list.
        public void LoadGoal()
        {
            string fileName= GetFileName();
            string[] lines = File.ReadAllLines(fileName);
            

            foreach (string line in lines)
            {
                // //breaks line text string data into parts
                string[] parts = line.Split(":");

                string type = parts[0];
                //string datastring = parts[1];

                if (parts[0] == "Score")
                {
                    _totalPoints = int.Parse(parts[1]);
                }
                else if (parts[0] == "Simple Goal")
                {
                    string simple = parts[1];
                    _simpleData.Add(simple);            
                }
                else if (parts[0] == "Checklist Goal")
                {
                    string list = parts[1];
                    _checkData.Add(list);
                }
                else if (parts[0] == "Eternal Goal")
                {
                    string eternal = parts[1];
                    _eternalData.Add(eternal);
                }
            }  

            //Split goal data strings that was loaded from file and add to goal list
            SplitSimpleData();      
            SplitCheckData();
            SplitEternalData();               
        }


        //Record event by listing goals, user picks, then abstract class methods record event and get points
        public void UserRecordEvent()
        {
            WriteLine("\nThe Goals Are:\n");

            
            ForegroundColor = ConsoleColor.Blue;

            int i = 1;
            foreach (Goal g in _goals)
            {
                WriteLine($"{i}. {g.GetGoalName()}");
                i += 1;
            }

            ForegroundColor = ConsoleColor.DarkRed;
            Write("\nWhich goal would you like to record?  ");
            ForegroundColor = ConsoleColor.Blue;

            int done = int.Parse(ReadLine()) - 1;

            _totalPoints += _goals[done].RecordEvent();
        }


        //Method to remove a goal from the list
        public void RemoveGoal()
        {
            ForegroundColor = ConsoleColor.Blue;
            ListGoal();

            ForegroundColor = ConsoleColor.DarkRed;
            Write("\nWhich goal would you like to remove?  ");
            ForegroundColor = ConsoleColor.Blue;

            int userDelete = int.Parse(ReadLine()) - 1;

            _goals.Remove(_goals[userDelete]);
        }


        //Simple goal data string list created when file loaded, gets split and added to Goal list
        private void SplitSimpleData()
        {
            foreach (string item in _simpleData)
            {
                string [] parts = item.Split("~|~");

                string name = parts[0];
                string description = parts[1];
                int points = int.Parse(parts[2]);
                bool status = Convert.ToBoolean(parts[3]);
                
                SimpleGoal simple = new SimpleGoal("Simple Goal", name, description, points, status);
                _goals.Add(simple);
            }
        }


        //Checklist goal data string list created when file loaded, gets split and added to Goal list
        private void SplitCheckData()
        {
            foreach (string item in _checkData)
            {
                string [] parts = item.Split("~|~");

                string name = parts[0];
                string description = parts[1];
                int points = int.Parse(parts[2]);
                int bonus = int.Parse(parts[3]);
                int times = int.Parse(parts[4]);
                int repeat = int.Parse(parts[5]);
            
                ChecklistGoal checklist = new ChecklistGoal("Checklist Goal", name, description, points, bonus, times, repeat);
                _goals.Add(checklist);
            }
        }


        //Eternal goal data string list created when file loaded, gets split and added to Goal list
        private void SplitEternalData()
        {
            foreach (string item in _eternalData)
            {
                string [] parts = item.Split("~|~");

                string name = parts[0];
                string description = parts[1];
                int points = int.Parse(parts[2]);
            
                EternalGoal eternal = new EternalGoal("Eternal Goal", name, description, points);
                _goals.Add(eternal);
            }
        }


        //Method that is used by load and save methods.  Gets a file name (creates it if needed) and verifies input is good
        public string GetFileName()
        {
            ForegroundColor = ConsoleColor.DarkRed;
            Write("\nWhat is the name of the goal file? ");
            ForegroundColor = ConsoleColor.Blue;
            string fileName = ReadLine();

            if (!File.Exists(fileName))
            {
                ForegroundColor = ConsoleColor.DarkRed;
                WriteLine($"\n'{fileName}' does not exist. Do you want to create a new file?");
                ForegroundColor = ConsoleColor.Blue;
                string answer = ReadLine().Trim().ToLower();
                if (answer == "yes")
                {
                    File.CreateText(fileName).Close();
                }
                else
                {
                    ForegroundColor = ConsoleColor.DarkRed;
                    WriteLine("\nWhat is the name of the goal file? ");
                    ForegroundColor = ConsoleColor.Blue;
                    fileName = ReadLine();
                }               
            }

            return fileName;
        }
    }
}

