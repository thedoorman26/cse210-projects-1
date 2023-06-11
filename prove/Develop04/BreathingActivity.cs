using System;
using static System.Console;

namespace Mindfulness
{
    class BreathingActivity : Activity
    {
        //no new variables in this class


        //Constructor for the class that gets access to the variables from the parent class.
        public BreathingActivity(string activity, string description) : base (activity, description)
        {
            
        }


        // The function displays a breathing exercise with a countdown.
        public void DisplayBreath()
        {
            WriteLine(($"\nBreathe IN... "));
            CountDown(4);
            WriteLine(($"\nBreathe OUT... "));
            CountDown(4);
        }
    }
}