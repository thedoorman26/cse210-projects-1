using System;
using static System.Console;

namespace Mindfulness
{
    class Menu
    {
        private string _choice;

        public Menu()
        {

        }

        public string GetChoice()
        {
            string choice = "";
            bool properChoice = false;

            do
            {
                //Menu choices for the user.
                WriteLine("\nPlease select a Mindfulness Activity.");
                WriteLine("\n1. Start Breathing Activity");
                WriteLine("2. Start Reflecting Activity");
                WriteLine("3. Start Listing Activity");
                WriteLine("4. Quit");
                
                Write("\nChoice: ");
                choice = ReadLine();

                //This section is to verify that the choice was actually correct and avoids user error problems.
                if (choice == "1" || choice == "2" || choice == "3" || choice == "4")
                {
                    properChoice = true;
                }
                else
                {
                    WriteLine($"\n'{choice}' is not an available choice. Enter another choice.");
                }
            } while (!properChoice);

            return choice;
        }
    }

      

    

}