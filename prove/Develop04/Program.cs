using System;
using static System.Console;

/* I exceeded core requirements in several ways. I continue to enjoy using ascii art and colors to make
the program more interesting.  However, I keep trying to learn new skills.  First, I added a grounding 
activity that works well for us with our son who has struggles.  Second, as I learned more about animations, 
I learned how to have the text "write" itself across the screen and did that for the activity description.  
I felt it made the directions stand out a little better and made reading them a little more exciting. I also 
added a utility effect to the pause and count down timers making them more customizable.  The countdown can 
be called and have a number passed in for how high it should start.  The pause timer can have a phrase passed
in so that one function can be used to say "starting" or "ending" or "wait", etc. This makes it so pause and
count down have one function each, but are each used in a couple of different ways.  
*/

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