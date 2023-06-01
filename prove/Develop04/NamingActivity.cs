using System;
using static System.Console;

namespace Mindfulness
{
    class NamingActivity : Activity
    {
        List<string> _hearList;
        List<string> _seeList;
        List<string> _feelList;

        public NamingActivity(string activity, string description, int time) : base(activity, description, time)
        {

        }
        
    }


}