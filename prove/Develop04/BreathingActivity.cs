using System;
using static System.Console;

namespace Mindfulness
{
    class BreathingActivity : Activity
    {

        public BreathingActivity(string activity, string description, int time) : base(activity, description, time)
        {

        }

        public void RunBreath(DateTime endTime)
        {
            DisplayActivityStart();

            while (DateTime.Now < endTime)
            {            
                DisplayBreath();
            }

            DisplayActivityClose();
        }

        public void DisplayBreath()
        {
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