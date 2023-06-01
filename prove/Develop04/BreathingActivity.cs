using System;
using static System.Console;

namespace Mindfulness
{
    class BreathingActivity : Activity
    {
        private string _in;
        private string _out;


        public BreathingActivity(string activity, string description, int time) : base(activity, description, time)
        {

        }
    }


}