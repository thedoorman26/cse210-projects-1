using System;
using static System.Console;

namespace EternalQuest
{
    class ListHandling
    {
        //private int _totalPoints;
        private List<Goal> _goals;

        List<string> _simpleData = new List<string>();
        List<string> _checkData = new List<string>();
        List<string> _eternalData = new List<string>();

        private int _totalPoints { get; set; }

        public ListHandling()
        {
            _goals = new List<Goal>();            
        }

        public void SetGoal(string type)
        {
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

            string category = type;
            if (category == "Simple Goal")
            {
                
                SimpleGoal simple = new SimpleGoal(category, goalName, goalDescription, goalPoints);
                _goals.Add(simple);                
            }

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
                ChecklistGoal checklist = new ChecklistGoal(category, goalName, goalDescription, goalPoints, bonus, repeat);
                _goals.Add(checklist);
            }

            else if (category == "Eternal Goal")
            {
                EternalGoal eternal = new EternalGoal(category, goalName, goalDescription, goalPoints);
                _goals.Add(eternal);
            }
        }

        public int GetPoints()
        {
            return _totalPoints;
        }

        public void ListGoal()
        {   
            int i = 1;
            foreach (Goal g in _goals)
            {
                WriteLine($"{i}. {g.DisplayGoal()}");
                i += 1;
            }
        }

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

        public void LoadGoal()
        {
            string fileName= GetFileName();
            string[] lines = File.ReadAllLines(fileName);
            

            foreach (string line in lines)
            {
                //WriteLine(line);
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
            SplitSimpleData();      
            SplitCheckData();
            SplitEternalData();               
        }

        private void SplitSimpleData()
        {
            foreach (string item in _simpleData)
            {
                string [] parts = item.Split("~|~");

            string name = parts[0];
            string description = parts[1];
            int points = int.Parse(parts[2]);
            string complete = parts[3];

            SimpleGoal simple = new SimpleGoal("Simple Goal", name, description, points, complete);
            _goals.Add(simple);
            }
        }

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
    }

}

