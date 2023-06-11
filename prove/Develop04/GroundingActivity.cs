using System;
using static System.Console;

namespace Mindfulness
{
    class GroundingActivity : Activity
    {
        //Private lists to store and display user answers
        private List<string> _hearList;
        private List<string> _seeList;
        private List<string> _feelList;


        /* This is a constructor method for the `GroundingActivity` class. It initializes three private
        fields `_hearList`, `_seeList`, and `_feelList` as new empty lists of strings and gets access to the 
        variables from the parent class. */
        public GroundingActivity(string activity, string description) : base(activity, description)
        {
            _hearList = new List<string>();
            _seeList = new List<string>();
            _feelList = new List<string>();
        }
        
        
        // The function displays named items in three different lists.        
        public void DisplayGrounding()
        {
            DisplayNamedItems(_hearList, "hear");
            DisplayNamedItems(_seeList, "see");
            DisplayNamedItems(_feelList, "touch");            
        }

        
        /* The function "PromptGrounding" calls three other functions to prompt the user to input their 
        item for hearing, seeing, and feeling.*/ 
        public void PromptGrounding()
        {
            NameHearing();
            NameSeeing();
            NameFeeling();
        }


        // The function prompts the user to enter three sounds they hear and adds them to a list.
        private void NameHearing()
        {
            WriteLine("\nQuickly enter 3 sounds you hear."); 
            Write("Sound #1: ");
            _hearList.Add(ReadLine());
            Write("Sound #2: ");
            _hearList.Add(ReadLine());
            Write("Sound #3: ");
            _hearList.Add(ReadLine());
        }


        // The function prompts the user to enter two things they see and adds them to a list.
        private void NameSeeing()
        {
            WriteLine("\nQuickly enter 2 things you see.");
            Write("See #1: ");
            _seeList.Add(ReadLine());
            Write ("See #2: ");
            _seeList.Add(ReadLine());
        }


        // The function prompts the user to enter something they can touch and adds them to a list.
        private void NameFeeling()
        {
            WriteLine("\nFinally, quickly enter something you can feel with your touch sense.");
            Write("Touch #1: ");
            _feelList.Add(ReadLine());
        }


        /* The function displays a list of named items and a sense associated with them. Parameters 
        take the list and sets the sense in the statement.*/        
        private void DisplayNamedItems(List<string> list, string sense)
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