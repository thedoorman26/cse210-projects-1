using System;
using static System.Console;
namespace Classes
{

    // Word holds the words that make up the scripture.
    class Word
    {
        //Private variables to hold the word attributes in the class
        private string _word;
        private bool _hidden;


        //Public array to hold the initial text attributes for the scripture
        public Word(string word)
        {
            _word = word;
            _hidden = false; 
        }


        //Method to put word parts together into a string
        public string GetScriptureWords()
        {
            string text = ($"{_word}");
            return text;
        }

        //Method to display the word string
        public void DisplayScriptureWords()
        {
            Console.WriteLine(GetScriptureWords());
        }


        //Split text string into a word list to be able to hide words
        public void SplitWordSring()
        {
            List<string> wordList = new List<string>();

            string[] scriptText = _word.Split(new char[] {' ', ',', '.', '?', '!'}, StringSplitOptions.RemoveEmptyEntries);

            wordList.AddRange(scriptText);
            
            foreach (string word in scriptText)
            {
                WriteLine(word);
            } 
            foreach (string word in wordList)
            {
                WriteLine(word);
            }

        }          


        // public string GetRenderedText()
        // {

        //     foreach (string word in wordList)
        //     {
        //         WriteLine(word);
        //     }   
        // }        

        //Method to hide indexed words
        public void HideWord()
        {
            _hidden = true;
        }


        //Method to send hidden status when called
        public bool IsHidden()
        {
            return _hidden;
        }

    }

}

