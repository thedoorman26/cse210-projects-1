using System;
using static System.Console;

namespace Mindfulness
{
    class GroundingActivity : Activity
    {
        List<string> _hearList;
        List<string> _seeList;
        List<string> _feelList;

        public GroundingActivity()
        {

        }

        public GroundingActivity(string activity, string description) : base(activity, description)
        {
            _hearList = new List<string>();
            _seeList = new List<string>();
            _feelList = new List<string>();
        }
        
        public void RunGrounding()
        {
            _activityTime = RequestActivityDuration();
            DateTime endTime = SetTimeDuration();

            while (DateTime.Now < endTime)
            { 
                NameHearing();
                NameSeeing();
                NameFeeling();
            }

            DisplayNamedItems(_hearList, "hear");
            DisplayNamedItems(_seeList, "see");
            DisplayNamedItems(_feelList, "touch");
            
        }

        public void NameHearing()
        {
            WriteLine("\nListen carefully to the sounds around you. Quickly enter 3 sounds you hear."); 
            Write("Sound #1: ");
            _hearList.Add(ReadLine());
            Write("Sound #2: ");
            _hearList.Add(ReadLine());
            Write("Sound #3: ");
            _hearList.Add(ReadLine());
        }

        public void NameSeeing()
        {
            WriteLine("\nNow, look around you and quickly enter 2 things you see.");
            Write("See #1: ");
            _seeList.Add( ReadLine());
            Write ("See #2: ");
            _seeList.Add( ReadLine());
        }

        public void NameFeeling()
        {
            WriteLine("\nFinally, quickly enter something you can feel with your touch sense.");
            Write("Touch #1: ");
            _feelList.Add(ReadLine());
        }

        public void DisplayNamedItems(List<string> list, string sense)
        {
            Write($"\nYou named {list.Count} things you could {sense}: ");
            foreach (string item in list)
            {
                Write($"'{item}' ");
            }
            WriteLine("");
        }
    }
}