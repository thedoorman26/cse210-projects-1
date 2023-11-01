using System;
using static System.Console;

namespace EternalQuest
{
    public abstract class Goal
    {
        //Private attributes used in the goal child classes
        private string _goalName;
        private string _goalDescription;
        private int _goalPoints;
        private string _goalType;
        private bool _complete;


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

        
        public string GetGoalDescription()
        {
            return _goalDescription;
        }


        //Getter method for goal points
        public int GetGoalPoints()
        {
            return _goalPoints;
        }

        public string GetGoalType()
        {
            return _goalType;
        }


        public bool GetComplete()
        {
            return _complete;
        }


        public void SetGoalName(string goalName)
        {
            goalName = _goalName;
        }


        public void SetGoalDescription(string goalDescription)
        {
            goalDescription = _goalDescription;
        }


        public void SetGoalPoints(int goalPoints)
        {
            goalPoints = _goalPoints;
        }


        public void SetGoalType(string goalType)
        {
            goalType = _goalType;
        }


        public void SetComplete(bool complete)
        {
            complete = _complete;
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