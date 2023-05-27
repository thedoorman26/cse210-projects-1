using System;
using static System.Console;


namespace ScriptureMemorization
{
    /* Menu class stores the menu itself and displays it when called. The varibles created from a Menu 
    choice is first stored here but passed into their corresponding classes via "get" functions.*/
    class Menu
    {
        //Private variables for the Menu class
        private string _userBook;
        private int _userChapter;
        private int _userVerse;
        private int _userEndVerse;
        private string _userText;
    

        /* This is a default constructor for the `Menu` class. It is used to create an instance of the `Menu` class without passing
        any initial values to its properties. */
        public Menu()
        {

        }


        // The method returns the value of a private variable called "_userBook".
        public string GetBook()
        {
            return _userBook;
        }


        // The method returns the value of a private variable called "_userChapter".
        public int GetChapter()
        {
            return _userChapter;
        }


        // The method returns the value of a private variable called "_userVerse".
        public int GetVerse()
        {
            return _userVerse;
        }


        // The method returns the value of a private variable called "_userEndVerse".
        public int GetEndVerse()
        {
            return _userEndVerse;
        }


        // The method returns the value of a private variable called "_userText".
        public string GetScriptText()
        {
            return _userText;
        }


        //Split scripture string returned from the users choice and assigns the parts to variables.
        public void SplitChoiceString(string choiceString)
        {
            string[] scriptdata = choiceString.Split('|');

            _userBook = scriptdata[0];
            _userChapter = int.Parse(scriptdata[1]);
            _userVerse = int.Parse(scriptdata[2]);
            _userEndVerse = int.Parse(scriptdata[3]);
            _userText = scriptdata[4];
        }


        //This is the choice menu that allows the user to pick a scripture to memorize.
        public string GetChoice()
        {
            string choice = "";
            bool properChoice = false;

            do
            {
                //Menu choices for the user.
                WriteLine("\nPlease select a scripture to memorize.");
                WriteLine("\n1. John 3:16");
                WriteLine("2. Proverbs 3:5-6");
                WriteLine("3. John 14:27");
                WriteLine("4. Moroni 7:41");
                WriteLine("5. Matthew 11:28-30");

                Write("\nChoice: ");
                choice = ReadLine();

                //This section is to verify that the choice was actually correct and avoids user error problems.
                if (choice == "1" || choice == "2" || choice == "3" || choice == "4" || choice == "5")
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

