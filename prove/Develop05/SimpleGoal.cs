using System;
using static System.Console;

namespace EternalQuest
{
    class SimpleGoal : Goal
    {
        bool complete;
        public SimpleGoal()
        {

        }

        public SimpleGoal(string type, string name, string description, int points) : base (type, name, description, points)
        {
            
        }

        public SimpleGoal(string type, string name, string description, int points, string status) : base (type, name, description, points)
        {
            complete = Convert.ToBoolean(status);
        }


        // public override void SetGoal(string type)
        // {
        //     base.SetGoal(type);
            
        // }
        public override string CreatSavedData()
        {
            string entryData = ($"{_goalType}:{_goalName}~|~{_goalDescription}~|~{_goalPoints}~|~{IsComplete()}\n");

            return entryData;           
        }
        public override string DisplayGoal()
        {
            string display = ($"[ ] {_goalType}: {_goalName} ({_goalDescription})");
            return display;
        }
        public override int CalculatePoints()
        {
            return _goalPoints;
        }
        public override void RecordEvent()
        {

        }
        public override bool IsComplete()
        {
            if (complete)
            {
                return true;
            }
            else
            {
            return false;
            }
        }
        
    }
}