using System;
using static System.Console;

namespace EternalQuest
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("\nHello Eternal Quest World!");

            //Pause for user to choose to go on
            WriteLine("\nPress any key to continue...");
            ReadKey();

            //Begins the menu class for user choices
            Menu choice = new Menu();     
            choice.MenuItem();
        }
    }
}