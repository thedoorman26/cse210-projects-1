using System;
using static System.Console;

namespace Mindfulness
{
    class BreathingActivity : Activity
    {
        private string _in = "IN";
        private string _out = "OUT";


        public BreathingActivity(string activity, string description, int time) : base(activity, description, time)
        {

        }

        public void RunBreath()
        {
            DisplayActivityStart();
            DisplayBreath();
            DisplayActivityClose();
        }
        public void DisplayBreath()
        {
            //TODO Messages to breathe in ... then out ...
            Write(($"\nBreathe {_in}..."));
            WriteLine("");
            Write(($"\nBreathe {_out}"));
            WriteLine("");
            WriteLine("");
        }

    }


}