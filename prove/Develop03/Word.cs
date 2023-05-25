using System;
using static System.Console;
namespace ScriptureMemorization
{

    // Word holds the words that make up the scripture.
    class Word
    {
        //Private variables to hold the word attributes in the class
        private string _verse;
        //private bool _hidden;
        private List<string> wordList = new List<string>();


        //Public array to hold the initial text attributes for the scripture
        public Word(string verse)
        {
            _verse = verse;
        //    _hidden = false; 
        }


        //Method to put word parts together into a string
        public string GetScriptureWords()
        {
            string text = ($"{_verse}");
            return text;
        }


        //Split text string into a word list to be able to hide words
        public void SplitWordSring()
        {
            string[] scriptText = _verse.Split(' ');
            wordList.AddRange(scriptText);
        }          

        
        public string GetRenderedText()
        {
            HideWord(); 
            string hiddenVerse = string.Join(" ", wordList);
            return hiddenVerse;
        }        


        public void DisplayRenderHidden()
        {
            WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n");
            WriteLine(GetRenderedText());
            WriteLine("\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

        }

        public void ContinueHideLoop()
        {            
            HideWord();
            Clear();
            DisplayRenderHidden();
        }

        //Method to hide indexed words
        public void HideWord()
        {
            //_hidden = true;
            Random random = new Random();
            int index = random.Next(0, wordList.Count);
            wordList[index] = "____";
        }
       

    }

}

