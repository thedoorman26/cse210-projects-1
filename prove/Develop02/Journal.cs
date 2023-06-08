using System;
using System.IO;
using System.Collections.Generic;
using static System.Console;

namespace Classes
{
    class Journal
    {
        //Class variable and list that holds the journal entry and file data.
        public string _filename = "";
        public List<Entry> _newEntries = new List<Entry>();

   
        //Constructor for the Journal Class.
        public Journal()
        {
                     
        }


        //Method for displaying the journal entries from the list.
        public void JournalEntryDetails()
        {
            WriteLine("\n************** Journal Entry **************");
            
            foreach (Entry e in _newEntries)
            {
                e.ShowEntryDetails();
            }
            WriteLine("\n******************** End ********************");
        }


        //Method for asking for a file name and creating a new file if one doesn't exist.
        public string CreateFile()
        {
            Write("What is the name of your journal file? ");
            _filename = ReadLine();
            if (!File.Exists(_filename))
            {
                File.CreateText(_filename).Close();
            }
            return _filename;                    
        }


        //Method for saving entries to a file.
        public void SaveToFile() 
        {
            WriteLine("\nSaving to file...");
            
            foreach (Entry e in _newEntries)
            {
                string entryData = e.CreatSavedData();
                File.AppendAllText(_filename, entryData);
            }

            WriteLine("\nFile Saved...");
        }


        //Method for clearing a file with a prompt to confirm the user wants everything cleared.
        public void ClearFile()
        {
            string response;
            
            WriteLine("Are you sure you want to clear the contents of the journal file? (yes/no)");
            response = ReadLine().Trim().ToLower();

            if (response == "yes")
            {
                File.WriteAllText(_filename, "");
                WriteLine("\nJournal is cleared.");
            }
            else 
            {
                WriteLine("\nJournal was not cleared.");
            }   
        }
    

        //Method for reading a file and converting data into a display format.
        public void ReadFromFile()
        {
            Write("\nWhat is the name of the file you want to load? ");
            _filename = ReadLine();

            if (!File.Exists(_filename))
            {
                WriteLine($"\n'{_filename}' does not exist.");
                Write("\nWhat is the name of the file you want to load? ");
                _filename = ReadLine();
            }

            WriteLine("\nReading Saved File...");
            string[] lines = File.ReadAllLines(_filename);

            WriteLine("\n************** Journal Entry **************");
            foreach (string line in lines)
            {
                //breaks line text string data into parts
                string[] parts = line.Split("~|~");

                //assigns part indexes to variables
                string entryTitle = parts[0];
                string entryDate = parts[1];
                string entryPrompt = parts[2];
                string entryAnswer = parts[3];
                
                //displays the entry by parts
                WriteLine($"\nTitle: {entryTitle}");
                WriteLine($"Date: {entryDate}");
                WriteLine($"Prompt: {entryPrompt}");
                WriteLine($"Answer: {entryAnswer}");
            }
            WriteLine("\n******************** End ********************");
        }
    }
}