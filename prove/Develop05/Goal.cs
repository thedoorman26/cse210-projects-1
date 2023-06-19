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
        
        public abstract string DisplayGoal();
        public abstract string CreatSavedData();
        public abstract void CalculatePoints();
        public abstract void RecordEvent();
        public abstract bool IsComplete();
    }
}