using System;
using static System.Console;
namespace ScriptureMemorization
{
    class Program
    {
        static void Main(string[] args)
        {
            
            DisplayWelcomeMessage();

            //Send reference and text of verse to the classes for the scripture that will be worked on
            Reference reference = new Reference("John", 3, 16);

            string verseText = ("For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.");
            Word verse = new Word(verseText);

            
            //Get reference and text info back from the classes to be displayed
            Scripture scripture = new Scripture((reference.GetReference()), (verse.GetScriptureWords()));
            scripture.DisplayFullScripture();


            WriteLine("\nPress enter to hide a word... or type 'quit' to end the program.");
            string input = ReadLine().Trim().ToLower();
            verse.SplitVerseIntoList();
            
            while (input != "quit")
            {
                verse.ContinueHideLoop();
                if (verse.IsCompletlyHidden())
                {
                    break;
                }             
                WriteLine("\nPress enter to hide a word... or type 'quit' to end the program.");
                input = ReadLine();
                WriteLine("Sorry you have to quit!");
                
            }

            //Closing message and art credit
            DisplayClosingMessage();
        }



        static void DisplayWelcomeMessage()
        {
            Title = "Scripture Memorization Program";
            BackgroundColor = ConsoleColor.White;
            ForegroundColor = ConsoleColor.Blue;
            //Opening image and welcome
            Clear();
            WriteLine("\n*/*/*/*/*/*  Welcome!!!  */*/*/*/*/*");
                string BookArt = @"
                                  _          _   _             
  /\/\   ___ _ __ ___   ___  _ __(_)______ _| |_(_) ___  _ __  
 /    \ / _ \ '_ ` _ \ / _ \| '__| |_  / _` | __| |/ _ \| '_ \ 
/ /\/\ \  __/ | | | | | (_) | |  | |/ / (_| | |_| | (_) | | | |
\/    \/\___|_| |_| |_|\___/|_|  |_/___\__,_|\__|_|\___/|_| |_|
                                                               
";
            WriteLine(BookArt);
            WriteLine("\nThis is the Scripture Memorization Program!");
        }


        static void DisplayClosingMessage()
        {
            WriteLine("\nThanks for working on memorizing a scripture!");
            WriteLine("\nThe program will end now.\n");
            WriteLine("");
            WriteLine("Art Credit: https://patorjk.com/software/taag/#p=testall&f=Graffiti&t=Memorization\n");
        }
    
    }

}



