using System;
using static System.Console;

namespace EternalQuest
{
    class ChecklistGoal : Goal
    {
        private int _repeatTimes;
        private int _timesCompleted;
        private int _bonusPoints;

        public ChecklistGoal()
        {
            
        }

        public ChecklistGoal(string type, string name, string description, int points) : base (type, name, description, points)
        {

        }

        public override void SetGoal()
        {
            _goalType = "Checklist Goal";
            Write("What is the name of your goal?  ");
            _goalName = ReadLine();
            Write("What is a short description of your goal?  ");
            _goalDescription = ReadLine();
            Write("What is the amount of points your goal is worth?  ");
            _goalPoints = int.Parse(ReadLine());
            Write("How many times does this goal need to be accomplished for a bonus?  ");
            _bonusPoints = int.Parse(ReadLine());
            Write("What is the bonus for accomplishing it that many times?  ");
            _repeatTimes = int.Parse(ReadLine());
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
            _timesCompleted += 1;
        }
        public override bool IsComplete()
        {
            return false;
        }
        
    }
}