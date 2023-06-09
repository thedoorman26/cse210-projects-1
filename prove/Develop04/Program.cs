using System;
using static System.Console;

namespace Mindfulness
{
    class Program
    {
        static void Main(string[] args)
        {
            //Intro Method
            DisplayIntro();
            
            //Pause for user to choose to go on
            WriteLine("Press any key to continue...");
            ReadKey();

            //Begins the menu class for user choices
            Menu choice = new Menu();     
            choice.MenuItem();

            //Exit message/end of program
            DisplayOutro();           

        }


        //Intro method set console color and message
        public static void DisplayIntro()
        {
            BackgroundColor = ConsoleColor.Gray;
            ForegroundColor = ConsoleColor.Yellow;
            Clear();

            string textIntro = @"
        _           _  __       _                     
  /\/\ (_)_ __   __| |/ _|_   _| |_ __   ___  ___ ___ 
 /    \| | '_ \ / _` | |_| | | | | '_ \ / _ \/ __/ __|
/ /\/\ \ | | | | (_| |  _| |_| | | | | |  __/\__ \__ \
\/    \/_|_| |_|\__,_|_|  \__,_|_|_| |_|\___||___/___/
                                                      
";
            WriteLine("\n~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~");
            WriteLine(textIntro);
            WriteLine("~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~\n");
            ForegroundColor = ConsoleColor.Blue;
            WriteLine("This is the Mindfulness Program where you can practice \ncalming and training your mind.\n");
        }


        //Outro method displays closing message and art credit
        public static void DisplayOutro()
        {
            Clear();
            ForegroundColor = ConsoleColor.DarkGreen;
            string textOutro = @"
 _   _                          ______          _    __       _  ______            _ 
| | | |                         | ___ \        | |  / _|     | | |  _  \          | |
| |_| | __ ___   _____    __ _  | |_/ /___  ___| |_| |_ _   _| | | | | |__ _ _   _| |
|  _  |/ _` \ \ / / _ \  / _` | |    // _ \/ __| __|  _| | | | | | | | / _` | | | | |
| | | | (_| |\ V /  __/ | (_| | | |\ \  __/\__ \ |_| | | |_| | | | |/ / (_| | |_| |_|
\_| |_/\__,_| \_/ \___|  \__,_| \_| \_\___||___/\__|_|  \__,_|_| |___/ \__,_|\__, (_)
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