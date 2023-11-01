using System;
using static System.Console;

namespace EternalQuest
{
    class SimpleGoal : Goal
    {
        //no new attributes needed in this class


        //Constructor used to pass arguments from the set goal method
        public SimpleGoal(string type, string name, string description, int points) : base (type, name, description, points)
        {
            
        }


        //Constructor used to load parsed data strings from a file
        public SimpleGoal(string type, string name, string description, int points, bool status) : base (type, name, description, points)
        {
           SetComplete(status);
        }


        //Method to create a string to save to a file
        public override string CreatSavedData()
        {
            string entryData = ($"{GetGoalType()}:{GetGoalName()}~|~{GetGoalDescription()}~|~{GetGoalPoints()}~|~{GetComplete()}\n");

            return entryData;           
        }


        //Method to display specific goal data
        public override string DisplayGoal()
        {
            string display = ($"{IsComplete()} {GetGoalType()}: {GetGoalName()} ({GetGoalDescription()})");

            return display;
        }


        //Method to record a goal for the user, marks it complete, sends points back to be added to total.
        public override int RecordEvent()
        {        
            WriteLine($"\nYou completed the simple goal '{GetGoalName()}' and gained {GetGoalPoints()} points!");
            MarkComplete();
            return GetGoalPoints();            
        }


        //Method to change the checkbox from empty to filled if complete
        public override string IsComplete()
        {
                return GetComplete() ? "[X]" : "[ ]";
        }
        
    }
}