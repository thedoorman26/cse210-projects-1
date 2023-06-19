using System;
using static System.Console;

namespace EternalQuest
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayIntro();
            WriteLine("\nHello Eternal Quest World!");

            //Pause for user to choose to go on
            WriteLine("\nPress any key to continue...");
            ReadKey();

            //Begins the menu class for user choices
            Menu choice = new Menu();     
            choice.MenuItem();

            DisplayOutro();
        }

        public static void DisplayIntro()
        {
            BackgroundColor = ConsoleColor.Gray;
            ForegroundColor = ConsoleColor.Yellow;
            Clear();

            string textIntro = @"
 _______ _________ _______  _______  _        _______  _          _______           _______  _______ _________
(  ____ \\__   __/(  ____ \(  ____ )( (    /|(  ___  )( \        (  ___  )|\     /|(  ____ \(  ____ \\__   __/
| (    \/   ) (   | (    \/| (    )||  \  ( || (   ) || (        | (   ) || )   ( || (    \/| (    \/   ) (   
| (__       | |   | (__    | (____)||   \ | || (___) || |        | |   | || |   | || (__    | (_____    | |   
|  __)      | |   |  __)   |     __)| (\ \) ||  ___  || |        | |   | || |   | ||  __)   (_____  )   | |   
| (         | |   | (      | (\ (   | | \   || (   ) || |        | | /\| || |   | || (            ) |   | |   
| (____/\   | |   | (____/\| ) \ \__| )  \  || )   ( || (____/\  | (_\ \ || (___) || (____/\/\____) |   | |   
(_______/   )_(   (_______/|/   \__/|/    )_)|/     \|(_______/  (____\/_)(_______)(_______/\_______)   )_(   
                                                                                                              
";
            WriteLine("\n*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*");
            for (int i = 0; i < textIntro.Length; i++)
            {
                Write(textIntro[i]);
                Thread.Sleep(1);
            }
            //WriteLine(textIntro);
            WriteLine("*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*\n");
            ForegroundColor = ConsoleColor.Blue;
            WriteLine("The program that makes setting goals fun and motivating!\n");
        }

        public static void DisplayOutro()
        {
            Clear();
            ForegroundColor = ConsoleColor.DarkGreen;
            string textOutro = @"
   _____ _                __  __       _   _            _           _ _ 
  / ____| |              |  \/  |     | | (_)          | |         | | |
 | (___ | |_ __ _ _   _  | \  / | ___ | |_ ___   ____ _| |_ ___  __| | |
  \___ \| __/ _` | | | | | |\/| |/ _ \| __| \ \ / / _` | __/ _ \/ _` | |
  ____) | || (_| | |_| | | |  | | (_) | |_| |\ V / (_| | ||  __/ (_| |_|
 |_____/ \__\__,_|\__, | |_|  |_|\___/ \__|_| \_/ \__,_|\__\___|\__,_(_)
                   __/ |                                                
                  |___/                                                 
";
            WriteLine("\n~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~");
            WriteLine(textOutro);
            WriteLine("~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~\n");
            ForegroundColor = ConsoleColor.Blue;
            WriteLine("\nArt Credit: https://patorjk.com/software/taag/#p=testall&f=Graffiti&t=Have%20a%20Restful%20Day!\n");
        }
    }
}