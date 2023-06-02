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
        
        public void RunNaming()
        {
            DisplayActivityStart();
            NamingPrompts();
            DisplayNamedItems();
            DisplayActivityClose();
        }
        
        public void NamingPrompts()
        {
            _hearList = new List<string>();
            _seeList = new List<string>();
            _feelList = new List<string>();

            //TODO WriteLine Naming Prompts and call track time
            WriteLine("Listen carefully to the sounds around you. Quickly name the sounds you hear."); 
            _hearList.Add(ReadLine());

            WriteLine("Now, look around you and quickly enter things you see.");
            _seeList.Add( ReadLine());

            WriteLine("Finally, quickly enter things you can feel with your touch sense.");
            _feelList.Add(ReadLine());
        }

        public void DisplayNamedItems()
        {
            //TODO Display count of named items
        }

        public void SplitNamedItems()
        {
            
        }
    }


}