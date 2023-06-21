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

        public ChecklistGoal(string type, string name, string description, int points, int bonus, int repeat) : base (type, name, description, points)
        {
            _repeatTimes = repeat;
            _bonusPoints = bonus;
        }

        public ChecklistGoal(string type, string name, string description, int points, int bonus, int times, int repeat) : base (type, name, description, points)
        {
            _timesCompleted = times;
            _repeatTimes = repeat;
        }

        // public override void SetGoal(string type)
        // {
        //     base.SetGoal(type);
            // Write("\nHow many times does this goal need to be accomplished for a bonus?  ");
            // int repeat = int.Parse(ReadLine());
            // Write($"What is the amount of bonus points for repeating the goal {repeat} times?  ");
            // int bonus = int.Parse(ReadLine());
            // ChecklistGoal checklist = new ChecklistGoal(category, goalName, goalDescription, goalPoints, bonus, repeat);
            // _goals.Add(checklist);
            
        // }

        public override string CreatSavedData()
        {
            string entryData = ($"{_goalType}~|~{_goalName}~|~{_goalDescription}~|~{_goalPoints}~|~{_bonusPoints}~|~{_timesCompleted}~|~{_repeatTimes}\n");
            return entryData;           
        }
        public override string DisplayGoal()
        {
            string display = ($"[ ] {_goalType}: {_goalName} ({_goalDescription}) -- Currently completed: {_timesCompleted}/{_repeatTimes} ");
            return display;
        }
        public override int CalculatePoints()
        {
            return 0;
        }
        public override void RecordEvent()
        {
            _timesCompleted += 1;
        }
        public override bool IsComplete()
        {
            if (_timesCompleted == _repeatTimes)
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