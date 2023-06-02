using System;
using static System.Console;

namespace Mindfulness
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayIntro();
            WriteLine("Press any key to continue...");
            ReadKey();

            Menu choice = new Menu();     
            choice.MenuAction();

            DisplayOutro();
            
            

        }

        public static void DisplayIntro()
        {
            string textIntro = @"
        _           _  __       _                     
  /\/\ (_)_ __   __| |/ _|_   _| |_ __   ___  ___ ___ 
 /    \| | '_ \ / _` | |_| | | | | '_ \ / _ \/ __/ __|
/ /\/\ \ | | | | (_| |  _| |_| | | | | |  __/\__ \__ \
\/    \/_|_| |_|\__,_|_|  \__,_|_|_| |_|\___||___/___/
                                                      
";
            WriteLine("\n~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~");
            WriteLine(textIntro);
            WriteLine("~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~\n");
            WriteLine("This is the Mindfulness Program where you can practice calming and training your mind.\n");
        }

        public static void DisplayOutro()
        {
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
            WriteLine("\nArt Credit: https://patorjk.com/software/taag/#p=testall&f=Graffiti&t=Have%20a%20Restful%20Day!\n");
        }
    }

}