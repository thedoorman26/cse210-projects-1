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

        public ChecklistGoal(string type, string name, string description, int points, int repeat, int bonus) : base (type, name, description, points)
        {
            _repeatTimes = repeat;
            _bonusPoints = bonus;
        }


        public override string CreatSavedData()
        {
            string entryData = ($"{_goalType}~|~{_goalName}~|~{_goalDescription}~|~{_goalPoints}\n");
            return entryData;           
        }
        public override string DisplayGoal()
        {
            string display = ($"[ ] {_goalType}: {_goalName} | {_goalDescription} | {_goalPoints}");
            return display;
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