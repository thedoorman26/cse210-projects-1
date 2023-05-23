using System;
using static System.Console;
namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Opening image and welcome
            DisplayWelcomeMessage();

            //Send reference and scripture text info to the classes for the scripture that will be worked on
            Reference reference = new Reference("John", 3, 16);
            Word text = new Word("For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.");

            //Get reference and text info back from the classes to be displayed
            Scripture scripture = new Scripture((reference.GetReference()), (text.GetScriptureWords()));
            scripture.DisplayFullScripture();

            WriteLine("\nPress any key to exit...");
            ReadKey();

            //Closing message and art credit
            DisplayClosingMessage();
        }

            static void DisplayWelcomeMessage()
        {
                string BookArt = @"(\ 
\'\ 
 \'\     __________  
 / '|   ()_________)
 \ '/    \ ~~~~~~~~ \
   \       \ ~~~~~~   \
   ==).      \__________\
  (__)       ()__________)";
                WriteLine(BookArt);
                WriteLine("\nWelcome to the Scripture Memorizer App!");
        }

        static void DisplayClosingMessage()
        {
            WriteLine("\nCongratulations on memorizing a scripture!");
            WriteLine("");
            WriteLine("Art Credit: https://www.asciiart.eu/books/books\n");
        }
    
    }

}



