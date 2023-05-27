using System;
using static System.Console;

/*Creativity and Exceeding Requirements Comment:
I have learned a lot these past two weeks. I have attempted to add some of that to this coding project.
I have learned how to change the background and foreground colors, learned how to turn text into ascii art,
I have also learned how to use concatination to leave the first letter of the hidden word behind as a "hint"
to the user.  Lastly, I added a menu option to pick from 5 scriptures that are stored in a string that is
ready to be split and the indexed parts stored into variables (parts learned but still needing practice from
previous assignment). I also put much more effort into making sure I cleaned up and explained my code with
comment lines/sections and good spacing.
 */


namespace ScriptureMemorization
{
    class Program
    {
        static void Main(string[] args)
        {
            // Function that displays a welcome message and an opening image for a Scripture Memorization Program. 
            DisplayWelcomeMessage();


            /* This code is creating a new instance of the `Menu` class and the `Scripture` class.*/ 
            Menu choice = new Menu();
            Scripture data = new Scripture();


            /* This prompts the user to enter a choice using the `GetChoice()` method of the `Menu`
            instance and stores the user's input in the `userChoice` variable.*/
            string userChoice = choice.GetChoice();

            //Takes the user's choice to retrieve a string of scripture data to memorize.
            string choiceString = data.ScriptureChoice(userChoice);

            //Passes the choice string back to Menu to breaks string up into useable variables.
            choice.SplitChoiceString(choiceString);

            
            //This creates a reference instance and sends individual parts to the reference class from the menu class
            Reference reference = new Reference(choice.GetBook(), choice.GetChapter(), choice.GetVerse(), choice.GetEndVerse());

            //This creates a word instance and sends the script text to the word class
            Word verse = new Word(choice.GetScriptText());

            /*This creates a new scripture instance and calls and sends the reference and verse info from the word and reference
            class to the scripture class.*/
            Scripture scripture = new Scripture((reference.GetReference()), (verse.GetScriptureWords()));


            //This function calls and displays the full scripture from scripture class.
            scripture.DisplayFullScripture();


            /* This code displays a message to the user, then reads the user's input and removes any leading
            or trailing white space and converts it to lowercase.*/
            WriteLine("\nWhen ready, press enter to hide words... or type 'quit' to end the program.");
            string input = ReadLine().Trim().ToLower();


            /* This method call splits the verse text into a list of individual words and stores it. This allows
            for individual words to be hidden during the memorization process. */
            verse.SplitVerseIntoList();
            

            /* This code creates a loop that continues until the user enters "quit". Within the loop, the method
            hides a random word in the verse. It then checks if all the words have been hidden. If all the words 
            have been hidden, the loop is exited using the `break` statement. If not, user can choose to hit enter
            to hide more words or 'quit' to end program.*/
            while (input != "quit")
            {
                verse.ContinueHideLoop();
                scripture.UpdateHiddenVerse((verse.GetHiddenVerse()));
                scripture.DisplayHiddenScript();
                if (verse.IsCompletlyHidden())
                {
                    break;
                }             
                WriteLine("\nPress enter to hide more words... or type 'quit' to end the program.");
                input = ReadLine();
                WriteLine("\nSorry you have to quit!");   
            }


            //This calls the Closing message and art credit and then the program ends.
            DisplayClosingMessage();

        }


/*These are functions that are specific to open and closing the program and didn't fit in the planned classes */

        // This function displays a welcome message and an opening image for a Scripture Memorization Program.
        static void DisplayWelcomeMessage()
        {
            //Background color
            BackgroundColor = ConsoleColor.White;
            ForegroundColor = ConsoleColor.Blue;

            //Clears the terminal so that new colors will apply
            Clear();

            //Welcome message and art
            WriteLine("\n*/*/*/*/*/*  Welcome!!!  */*/*/*/*/*");
            string welcomeArt = @"
                                  _          _   _             
  /\/\   ___ _ __ ___   ___  _ __(_)______ _| |_(_) ___  _ __  
 /    \ / _ \ '_ ` _ \ / _ \| '__| |_  / _` | __| |/ _ \| '_ \ 
/ /\/\ \  __/ | | | | | (_) | |  | |/ / (_| | |_| | (_) | | | |
\/    \/\___|_| |_| |_|\___/|_|  |_/___\__,_|\__|_|\___/|_| |_|
                                                               
";
            WriteLine(welcomeArt);
            WriteLine(($"\nThis is the Scripture Memorization Program!"));
        }


        /* The function displays a closing message and art for the scripture memorization program as well. 
        as the art credit. */
        static void DisplayClosingMessage()
        {
            string endArt = @"
  _______ _            ______           _ 
 |__   __| |          |  ____|         | |
    | |  | |__   ___  | |__   _ __   __| |
    | |  | '_ \ / _ \ |  __| | '_ \ / _` |
    | |  | | | |  __/ | |____| | | | (_| |
    |_|  |_| |_|\___| |______|_| |_|\__,_|
                                          
                                          
";
            WriteLine("\n***  Thanks for working on memorizing a scripture!  ***");
            WriteLine(endArt);
            WriteLine("===  Art Credit: https://patorjk.com/software/taag/#p=testall&f=Graffiti&t=Memorization  ===\n");
        }            
    }
}



