using System;
using static System.Console;
namespace ScriptureMemorization
{

    // Scripture class represents the scripture itself
    class Scripture
    {
        private string _reference;
        private string _scriptText;
        private List<string> wordList = new List<string>();


        public Scripture(string reference, string verse)
        {
            _reference = reference;
            _scriptText = verse;
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