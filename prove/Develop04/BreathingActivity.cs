using System;
using static System.Console;

namespace Mindfulness
{
    class BreathingActivity : Activity
    {

        public BreathingActivity()
        {
            
        }

        public BreathingActivity(string activity, string description) : base(activity, description)
        {
           
        }

        public void RunBreath()
        {   
            _activityTime = RequestActivityDuration();
            PauseTime("Get Ready");

            DateTime endTime = SetTimeDuration();

            while (DateTime.Now < endTime)
            {            
                DisplayBreath();
            }            
        }

        public void DisplayBreath()
        {
            Write(($"\n\nBreathe IN... "));
            CountDown(6);
            WriteLine("");
            Write(($"\nBreathe OUT... "));
            CountDown(6);
            WriteLine("");
        }
    }
}