using System;
using static System.Console;
namespace Classes
{

    // Word holds the words that make up the scripture.
    class Word
    {
        //Private variables to hold the word attributes in the class
        private string _word;
        private bool _isHidden;
        private List<Word> words;


        //Public array to hold the initial text attributes for the scripture
        public Word(string word)
        {
            _word = word;
            _isHidden = false;   
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

        public void SplitWordSring()
        {

           
        }        

    }

}

