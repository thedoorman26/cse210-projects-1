using System;
using static System.Console;

namespace EternalQuest
{
    class EternalGoal : Goal
    {
        //No additional attributes needed in this class


        //Constructor used to pass arguments from the set goal method and load file data
        public EternalGoal(string type, string name, string description, int points) : base (type, name, description, points)
        {

        }


        //Method to create a string to save to a file
        public override string CreatSavedData()
        {
            string entryData = ($"{_goalType}:{_goalName}~|~{_goalDescription}~|~{_goalPoints}\n");
            return entryData;           
        }


        //Method to display specific goal data
        public override string DisplayGoal()
        {
            string display = ($"{IsComplete()} {_goalType}: {_goalName} ({_goalDescription})");
            return display;
        }


        //Method to record a goal for the user and sends points back to be added to total.
        public override int RecordEvent()
        {
            WriteLine($"\nYou recorded progress for the eternal goal '{GetGoalName()}' and gained {GetGoalPoints()} points!");

            return GetGoalPoints();
        }


        //Method sets blank brackets, and they stay that way since this goal is never complete
        public override string IsComplete()
        {
            return "[ ]";
        }        
    }
}