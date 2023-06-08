using System;
using static System.Console;
namespace Classes
{

    class Menu
    {
        //Choice variable for the Menu class
        private string _choice;
        

        //Constructor for the Menu Class
        public Menu()
        {

        }


        //Method for displaying menu and getting the user's choice, as well as verify the choice is proper.
        public string GetChoice()
        {
            bool properchoice = false;

            do
            {
                WriteLine("\nPlease select one of the following choices:");
                WriteLine("\n1. Write");
                WriteLine("2. Display");
                WriteLine("3. Save");
                WriteLine("4. Load");
                WriteLine("5. Clear File");
                WriteLine("6. Quit");
                Write("\nWhat would you like to do? ");

                _choice = ReadLine();

                if (_choice == "1" || _choice == "2" || _choice == "3" || _choice == "4" || _choice == "5" || _choice == "6")
                {
                    properchoice = true;
                }
                else
                {
                    WriteLine($"\n'{_choice}' is not an available choice. Enter another choice.");
                }
            } while (!properchoice);

            return _choice;
        }


        //Method takes the user's choice and uses switch to instantiate or call the right method for the choice.
        public void MenuAction()
        {
            string choice;
            List<Entry> _newEntries = new List<Entry>();
            Journal entry = new Journal();
            
            do
            {                                    
                choice = GetChoice();
                
                switch (choice)
                {
                    case "1":
                        //write journal entry
                        string _date = FindDate();
                        string _rPrompt = RetrievePrompt(); 
                        WriteLine($"\nPrompt: {_rPrompt}");
                        Write("\nAnswer: ");
                        string _userEntry = ReadLine().Trim();

                        //Set entry title
                        Write("Enter a title for this entry: ");
                        string _userTitle = ReadLine().Trim();

                        //Instantiate entry and send off arguments to entry class
                        Entry newEntry = new Entry(_userTitle, _date, _rPrompt, _userEntry);

                        //Add newEntry to the _newEntries List.
                        _newEntries.Add(newEntry);                        
                        break;

                    case "2":
                        //display journal entry
                        entry._newEntries = _newEntries;
                        entry.JournalEntryDetails();                        
                        break;

                    case "3":
                        // save to journal file
                        entry._newEntries = _newEntries; 
                        entry._filename = entry.CreateFile();                                                  
                        entry.SaveToFile();                                               
                        break;

                    case "4":
                        //load journal file
                        entry.ReadFromFile();                         
                        break;
                    
                    case "5":
                        // clear file
                        entry.ClearFile();
                        break;

                    default:
                        break;
                }
            } while (choice != "6");
        }


        //Method gets the date and returns it to be used with entries
        public string FindDate()
        {
            DateTime currentTime = DateTime.Now;
            string dateText = currentTime.ToShortDateString();
            return dateText;
        }


        //Method
        public string RetrievePrompt()
        {
            Prompts newprompt = new Prompts();
            string _rprompt = newprompt.ShowRandomPrompt();
            return _rprompt;            
        }
    }
}