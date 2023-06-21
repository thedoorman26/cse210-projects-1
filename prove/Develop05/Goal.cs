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
        
        //protected string _goalType { get; set; }

        public Goal()
        {
           
        }

        public Goal(string type, string name, string description, int points)
        {
            _goalName = name;
            _goalDescription = description;
            _goalPoints = points;
            _goalType = type;           
        }
        
        // public virtual void SetGoal(string type)
        // {
        //     _goalType = type;
        //     ForegroundColor = ConsoleColor.DarkRed;
        //     Write("\nWhat is the name of your goal?  ");
        //     ForegroundColor = ConsoleColor.Blue;
        //     _goalName = ReadLine();
        //     ForegroundColor = ConsoleColor.DarkRed;
        //     Write("What is a short description of your goal?  ");
        //     ForegroundColor = ConsoleColor.Blue;
        //     _goalDescription = ReadLine();
        //     ForegroundColor = ConsoleColor.DarkRed;
        //     Write("What is the amount of points your goal is worth?  ");
        //     ForegroundColor = ConsoleColor.Blue;
        //     _goalPoints = int.Parse(ReadLine());
        // }
        
        public abstract string DisplayGoal();
        public abstract string CreatSavedData();
        public abstract int CalculatePoints();
        public abstract void RecordEvent();
        public abstract bool IsComplete();
    }
}