using System;
using static System.Console;

namespace Mindfulness
{
    class ReflectionActivity: Activity
    {
        private List<string> _reflectPrompt;
        private List<string> _reflectQuestion;

        public ReflectionActivity(string activity, string description, int time) : base(activity, description, time)
        {

        }

        public void RunReflection()
        {
            
        }
    }


}