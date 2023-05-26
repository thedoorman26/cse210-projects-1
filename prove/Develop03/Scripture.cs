using System;
using static System.Console;
namespace ScriptureMemorization
{

    // Scripture class stores the scripture itself and displays it when called.
    class Scripture
    {
        /* These are private fields in the `Scripture` class that store the reference and text of the scripture
        respectively. They are used to initialize the object when it is created and to retrieve the
        scripture parts when needed. */
        private string _reference;
        private string _scriptText;



        /* This is a constructor method for the `Scripture` class that takes two parameters:
        `reference` and `verse`, both of type `string`. When a new `Scripture` object is created,
        this constructor is called and it initializes the private fields `_reference` and
        `_scriptText` with the values of the `reference` and `verse` parameters, respectively. */
        public Scripture(string reference, string verse)
        {
            _reference = reference;
            _scriptText = verse;
        }


    
        // The function returns a string containing the reference and text of a scripture and returns the string for display.
        public string GetScriptureParts()
        {
            return ($"\n{_reference}\n{_scriptText}");
        }



        // This function displays a full scripture to memorize with a header and footer.
        public void DisplayFullScripture()
        {
            WriteLine("\n*********************************************** Scripture to Memorize ***********************************************");
            WriteLine(GetScriptureParts());
            WriteLine("\n*********************************************************************************************************************");
        }               
    }
}