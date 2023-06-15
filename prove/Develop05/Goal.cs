using System;
using static System.Console;

namespace EternalQuest
{
    public abstract class Goal
    {

        protected string _goalName;
        protected string _goalDescription;
        protected int _goalPoints;
        protected string _goalType;
        private int _totalPoints;
        private List<Goal> _goals;

        public Goal()
        {
           
        }
        public Goal(string type)
        {
            _goalType = type;
        }
        public Goal(string type, string name, string description, int points)
        {
            _goalName = name;
            _goalDescription = description;
            _goalPoints = points;
            _goalType = type;
            _goals = new List<Goal>();
        }
        
        public void RunGoal(string type)
        {
            if (_goalType == "Simple Goal")
            {
                SetGoal();
            }
            else if (_goalType == "Checklist Goal")
            {
                SetGoal();
            }
            else if (_goalType == "Eternal Goal")
            {
                SetGoal();
            }
        }

        public abstract string CreatSavedData();
        

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

        public virtual void SetGoal()
        {
            Write("What is the name of your goal?  ");
            _goalName = ReadLine();
            Write("What is a short description of your goal?  ");
            _goalDescription = ReadLine();
            Write("What is the amount of points your goal is worth?  ");
            _goalPoints = int.Parse(ReadLine());
        }

        public int GetPoints()
        {
            return _totalPoints;
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

        }

        public void ListGoal()
        {

        }
        public abstract void CalculatePoints();
        public abstract void RecordEvent();
        public abstract bool IsComplete();
    }
}