using System;
using static System.Console;

namespace EternalQuest
{
    class ListHandling
    {
        //private int _totalPoints;
        private List<Goal> _goals;

        private int _totalPoints { get; set; }

        public ListHandling()
        {
            _goals = new List<Goal>();            
        }

        public void SetGoal(string type)
        {
            Write("What is the name of your goal?  ");
            string goalName = ReadLine();
            Write("What is a short description of your goal?  ");
            string goalDescription = ReadLine();
            Write("What is the amount of points your goal is worth?  ");
            int goalPoints = int.Parse(ReadLine());

            string category = type;
            if (category == "Simple Goal")
            {
                SimpleGoal simple = new SimpleGoal(category, goalName, goalDescription, goalPoints);
                _goals.Add(simple);                
            }

            else if (category == "Checklist Goal")
            {
                Write("How many times does this goal need to be accomplished for a bonus?  ");
                int repeat = int.Parse(ReadLine());
                Write($"What is the amount of bonus points for repeating the goal {repeat} times?  ");
                int bonus = int.Parse(ReadLine());
                ChecklistGoal checklist = new ChecklistGoal(category, goalName, goalDescription, goalPoints, repeat, bonus);
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
            Write("What is the name of your goal file? ");
            string fileName = ReadLine();
            if (!File.Exists(fileName))
            {
                File.CreateText(fileName).Close();
            }
            
            File.WriteAllText(fileName, ($"{_totalPoints}\n"));

            foreach (Goal g in _goals)
            {
                string entryData = g.CreatSavedData();
                File.AppendAllText(fileName, entryData);
            }
        }

        public void LoadGoal()
        {
            Write("\nWhat is the name of the file you want to load? ");
            string filename = ReadLine();

            if (!File.Exists(filename))
            {
                WriteLine($"\n'{filename}' does not exist.");
                Write("\nWhat is the name of the file you want to load? ");
                filename = ReadLine();
            }

            WriteLine("\nReading Saved File...");
            string[] lines = File.ReadAllLines(filename);

            WriteLine("\n************** Goals **************");
            foreach (string line in lines)
            {
                WriteLine(line);
                // //breaks line text string data into parts
                // string[] parts = line.Split("~|~");

                // //assigns part indexes to variables
                // string entryTitle = parts[0];
                // string entryDate = parts[1];
                // string entryPrompt = parts[2];
                // string entryAnswer = parts[3];
                
                // //displays the entry by parts
                // WriteLine($"\nTitle: {entryTitle}");
                // WriteLine($"Date: {entryDate}");
                // WriteLine($"Prompt: {entryPrompt}");
                //WriteLine($"Answer: {entryAnswer}");
            }
            WriteLine("\n******************** End ********************");
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

