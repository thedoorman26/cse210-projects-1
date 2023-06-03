using System;
using static System.Console;

namespace Mindfulness
{
    class BreathingActivity : Activity
    {

        public BreathingActivity(string activity, string description, int time) : base(activity, description, time)
        {

        }

        public void RunBreath()
        {
            DisplayActivityStart();
            PauseTime();
            DisplayBreath();
            DisplayActivityClose();
        }
        public void DisplayBreath()
        {
            //TODO Messages to breathe in ... then out ...
            Write(($"\nBreathe IN..."));
            CountDown();
            WriteLine("");
            Write(($"\nBreathe OUT..."));
            CountDown();
            WriteLine("");
            WriteLine("");
        }

    }


}