using System;
using static System.Console;

namespace EternalQuest
{
    class EternalGoal : Goal
    {


        public EternalGoal()
        {
            
        }

        public EternalGoal(string type, string name, string description, int points) : base (type, name, description, points)
        {

        }

        public override void SetGoal()
        {
            _goalType = "Eternal Goal";
            Write("What is the name of your goal?  ");
            _goalName = ReadLine();
            Write("What is a short description of your goal?  ");
            _goalDescription = ReadLine();
            Write("What is the amount of points your goal is worth?  ");
            _goalPoints = int.Parse(ReadLine());
        }

        public override string CreatSavedData()
        {
            string entryData = ($"{_goalType}~|~{_goalName}~|~{_goalDescription}~|~{_goalPoints}\n");
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