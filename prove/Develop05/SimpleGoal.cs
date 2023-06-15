using System;
using static System.Console;

namespace EternalQuest
{
    class SimpleGoal : Goal
    {

        public SimpleGoal()
        {

        }

        public SimpleGoal(string type, string name, string description, int points) : base (type, name, description, points)
        {
            
        }

        public override void SetGoal()
        {
            // _goalType = "Simple Goal";
            // Write("What is the name of your goal?  ");
            // _goalName = ReadLine();
            // Write("What is a short description of your goal?  ");
            // _goalDescription = ReadLine();
            // Write("What is the amount of points your goal is worth?  ");
            // _goalPoints = int.Parse(ReadLine());
            // List<Goal> _goals = new List<Goal>();

            
        }

        public override string CreatSavedData()
        {
            string entryData = ($"{_goalType}~|~{_goalName}~|~{_goalDescription}~|~{_goalPoints}~|~{IsComplete()}\n");

            return entryData;           
        }
        public override void CalculatePoints()
        {

        }
        public override void RecordEvent()
        {

        }
        public override bool IsComplete()
        {
            return false;
        }
        
    }
}