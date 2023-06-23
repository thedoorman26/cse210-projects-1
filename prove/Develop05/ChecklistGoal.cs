using System;
using static System.Console;

namespace EternalQuest
{
    class ChecklistGoal : Goal
    {
        //additional attributes needed for the checklist class
        private int _repeatTimes;
        private int _timesCompleted;
        private int _bonusPoints;


        //Constructor used to pass arguments from the set goal method
        public ChecklistGoal(string type, string name, string description, int points, int bonus, int repeat) : base (type, name, description, points)
        {
            _repeatTimes = repeat;
            _bonusPoints = bonus;
        }


        //Constructor used to load parsed data strings from a file
        public ChecklistGoal(string type, string name, string description, int points, int bonus, int times, int repeat) : base (type, name, description, points)
        {
            _timesCompleted = times;
            _repeatTimes = repeat;
            _bonusPoints = bonus;
        }


        //Getter method for goal bonus
        public int GetBonusPoints()
        {
            return _bonusPoints;
        }


        //Getter method for goal times completed
        public int GetTimesCompleted()
        {
            return _timesCompleted;
        }


        //Setter method for goal times completed
        public int SetTimesCompleted()
        {
            return _timesCompleted ++;
        }


        //Getter method for goal repeat times
        public int GetRepeatTimes()
        {
            return _repeatTimes;
        }


        //Method to create a string to save to a file
        public override string CreatSavedData()
        {
            string entryData = ($"{_goalType}:{_goalName}~|~{_goalDescription}~|~{_goalPoints}~|~{_bonusPoints}~|~{_timesCompleted}~|~{_repeatTimes}\n");
            return entryData;           
        }


        //Method to display specific goal data
        public override string DisplayGoal()
        {
            string display = ($"{IsComplete()} {_goalType}: {_goalName} ({_goalDescription}) -- Currently completed: {_timesCompleted}/{_repeatTimes} ");
            return display;
        }


        //Method to record a goal for the user, adds 1 to times completed, checks to see if bonus earned, sends points back to be added to total.
        public override int RecordEvent()
        {
            SetTimesCompleted();

            //if repeat is done, marks complete and sends back points for both the goal and the bonus.
            if (GetTimesCompleted() == GetRepeatTimes())
            {
                WriteLine($"\nCongratulations! You completed the checklist goal '{GetGoalName()}' and gained a bonus of {GetBonusPoints()} points!");
                MarkComplete();
                
                return (GetGoalPoints() + GetBonusPoints());
            }

            //if repeat not reached, sends back goal points
            else if (GetTimesCompleted() < GetRepeatTimes())
            {
                WriteLine($"\nYou completed an item for the checklist goal '{GetGoalName()}' and gained {GetGoalPoints()} points!");

                return GetGoalPoints();
            }

            //points out they already finished this goal
            else
            {
                WriteLine($"\nYou have already completed the checklist goal '{GetGoalName()}'.");

                return 0;
            }            
        }


        //Method to change the checkbox from empty to filled if complete
        public override string IsComplete()
        {            
            return _complete ? "[X]" : "[ ]";            
        }
        
    }
}