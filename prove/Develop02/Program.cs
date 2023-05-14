using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace Classes
{

    class Program
    {
         public static void Main(string[] args)
        {   
            Title = "Journal App";         
            DisplayWelcomeMessage();
            Journal.CreateFile();
            
            MenuAction();
                      
            DisplayDismisalMessage();
        }

        
        public static void DisplayWelcomeMessage()
        {
            string BookArt = @"    __________________   __________________
.-/|                  \ /                  |\-.
||||                   |                   ||||
||||                   |       ~~*~~       ||||
||||    --==*==--      |                   ||||
||||                   |                   ||||
||||                   |                   ||||
||||                   |     --==*==--     ||||
||||                   |                   ||||
||||                   |                   ||||
||||                   |                   ||||
||||                   |                   ||||
||||__________________ | __________________||||
||/===================\|/===================\||
`--------------------~___~-------------------''";
            Console.WriteLine(BookArt);
            Console.WriteLine("\nWelcome to the Journal Program!");
        }

        
        public static string GetChoice()
        {
            string choice = "";
            bool properchoice = false;

            do
            {
                Console.WriteLine("\nPlease select one of the following choices:");
                Console.WriteLine("\n1. Write");
                Console.WriteLine("2. Display");
                Console.WriteLine("3. Load");
                Console.WriteLine("4. Save");
                Console.WriteLine("5. Clear File");
                Console.WriteLine("6. Quit");
                Console.Write("\nWhat would you like to do? ");

                choice = Console.ReadLine();

                if (choice == "1" || choice == "2" || choice == "3" || choice == "4" || choice == "5" || choice == "6")
                {
                    properchoice = true;
                }
                else
                {
                    Console.WriteLine($"\n'{choice}' is not an available choice. Enter another choice.");
                }
            } while (!properchoice);

            return choice;
        }
        public static void MenuAction()
        {
            string choice;
            
            do
            {        
                choice = GetChoice();
                string date = FindDate();
                string rPrompt = RetrievePrompt();
                switch (choice)
                {
                    case "1":
                        //write journal entry 
                        Console.WriteLine($"\nPrompt: {rPrompt}");
                        Console.Write("\nAnswer: ");
                        string userEntry = Console.ReadLine().Trim();
                        Console.Write("Enter a title for this entry: ");
                        string userTitle = Console.ReadLine();
                        Entry newEntry = new Entry(userTitle, date, rPrompt, userEntry);                                              
                        Journal.addEntry(newEntry);                        
                        break;

                    case "2":
                        //display journal entry
                        Journal.JournalEntryDetails();                        
                        break;

                    case "3":
                        //load journal file
                        Journal.ReadFromFile();                        
                        break;

                    case "4":
                        // save to journal file                                                   
                        Journal.SaveToFile();                        
                        break;
                    
                    case "5":
                        // clear file
                        Journal.ClearFile();
                        break;

                    default:
                        break;
                }
            } while (choice != "6");
        }
        public static string FindDate()
        {
            DateTime currentTime = DateTime.Now;
            string dateText = currentTime.ToShortDateString();
            return dateText;
        }
        public static string RetrievePrompt()
        {
            Prompts newprompt = new Prompts();
            string rprompt = newprompt.ShowRandomPrompt();
            return rprompt;            
        }
        public static void DisplayDismisalMessage()
        {
            Console.WriteLine("\nThanks for recording your thoughts!\n");
            Console.WriteLine("Art Credit: https://www.asciiart.eu/books/books\n");
        }
    }
}
