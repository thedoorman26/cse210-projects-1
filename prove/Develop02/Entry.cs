using System;
using static System.Console;

namespace Classes
{
    class Entry
    {   
        //Class variables to hold the different parts of the entry
        public string _prompt;
        public string _entry;
        public string _date;
        public string _title;

        
        //Constructor for the Entry class that receives arguments and assigns values to the class variables.
        public Entry(string ent_title, string ent_date, string ent_prompt, string ent_entry)
        {
            _title = ent_title;
            _date = ent_date;
            _prompt = ent_prompt;
            _entry  = ent_entry;
        }

        //Method for displaying the entry details in a specific format.
        public void ShowEntryDetails()
        {
            WriteLine($"\nTitle: {_title}");
            WriteLine($"Date: {_date}");
            WriteLine($"Prompt: {_prompt}");
            WriteLine($"Entry: {_entry}");
        }

        //Method to create the string for writing the data to a file that can be separated later.
        public string CreatSavedData()
        {
            string entryData = ($"{_title}~|~{_date}~|~{_prompt}~|~{_entry}\n");
            return entryData;
        }
    }
}