using System;
using static System.Console;

namespace EternalQuest
{
    class Program
    {
        static void Main(string[] args)
        {
            //Beginning Art and Explanation
            DisplayIntro();


            //Pause for user to choose to go on
            ForegroundColor = ConsoleColor.Gray;
            WriteLine("\nPress any key to continue...");
            ReadKey();
            ForegroundColor = ConsoleColor.Blue;


            //Begins the menu class for user choices, user choices of the program run from Menu
            Menu choice = new Menu();     
            choice.MenuItem();


            //Closing Art and art credit, end of program
            DisplayOutro();
        }


        //Intro Method
        public static void DisplayIntro()
        {
            BackgroundColor = ConsoleColor.Yellow;
            ForegroundColor = ConsoleColor.DarkRed;
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
            WriteLine("\n*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*");            
            WriteLine(textIntro);
            WriteLine("*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*\n");
            ForegroundColor = ConsoleColor.Blue;
            WriteLine("The program that makes setting goals fun and motivating!\n");
            WriteLine("Set goals, work hard, and then record goals to earn points and increase your Goal Master level!!!");
        }


        //Outro Method
        public static void DisplayOutro()
        {
            Clear();
            ForegroundColor = ConsoleColor.DarkRed;
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
            WriteLine("\n~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^");
            WriteLine(textOutro);
            WriteLine("\n~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^");
            ForegroundColor = ConsoleColor.Blue;
            WriteLine("\nArt Credit: https://patorjk.com/software/taag/#p=testall&f=Graffiti&t=Have%20a%20Restful%20Day!");
            WriteLine("https://www.asciiart.eu/miscellaneous/badges ; Art by Joan G. Stark\n");
        }
    }
}