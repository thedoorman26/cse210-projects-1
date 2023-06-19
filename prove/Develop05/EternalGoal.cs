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

        }
        public override bool IsComplete()
        {
            return false;
        }
        
    }
}