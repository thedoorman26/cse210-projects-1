using System;
using static System.Console;

namespace Mindfulness
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Develop04 World!");

            Menu choice = new Menu();
            string userChoice = choice.GetChoice();
            WriteLine(userChoice);
            choice.MenuAction(userChoice);
            ReadKey();

        }
    }

}