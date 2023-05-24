using System;
using static System.Console;
namespace Classes
{

    // Scripture class represents the scripture itself
    class Scripture
    {
        private string _reference;
        private string _scriptText;


        public Scripture(string reference, string text)
        {
            _reference = reference;
            _scriptText = text;
        }

    
        public string GetScriptureParts()
        {
            return ($"\n{_reference}\n{_scriptText}");
        }

        public void DisplayFullScripture()
        {
            WriteLine("\n*********************************************** Scripture to Memorize ***********************************************");
            WriteLine(GetScriptureParts());
            WriteLine("\n*********************************************************************************************************************");

        }

        
    }

}