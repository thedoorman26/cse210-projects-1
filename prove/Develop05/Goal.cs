using System;
using static System.Console;

namespace EternalQuest
{
    public abstract class Goal
    {
        //Private attributes used in the goal child classes
        protected string _goalName;
        protected string _goalDescription;
        protected int _goalPoints;
        protected string _goalType;
        protected bool _complete;


        //Goal constructor
        public Goal()
        {
          
        }


        //Constructor to set base attributes
        public Goal(string type, string name, string description, int points)
        {
            _goalName = name;
            _goalDescription = description;
            _goalPoints = points;
            _goalType = type;           
        }
        

        //Getter method for goal name
        public string GetGoalName()
        {
            return _goalName;
        }


        //Getter method for goal points
        public int GetGoalPoints()
        {
            return _goalPoints;
        }
        

        //Bool to change complete status
        public virtual bool MarkComplete()
        {
            _complete = true;
            return  _complete;
        }


        //Abstract methods that are overridden in the child classes
        public abstract string DisplayGoal();
        public abstract string CreatSavedData();
        public abstract int RecordEvent();
        public abstract string IsComplete();
    }
}