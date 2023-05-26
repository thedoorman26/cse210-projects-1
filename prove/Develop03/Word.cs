using System;
using System.Collections.Generic;
using static System.Console;
namespace ScriptureMemorization
{

    // Word class holds the words that make up the scripture. Also, handles all methods for hiding and rendering hiden words.
    class Word
    {
        /* These are private fields of the `Word` class. */    
        private string _verse;
        private List<string> _wordList;
        private List<int> _numIndex;
        private int _index;
        


        /* This is a constructor method for the `Word` class that takes a string parameter `verse` and
        assigns it to the private field `_verse`. This allows an instance of the `Word` class to be
        created with an initial value for the scripture text. */
        public Word(string verse)
        {
            _verse = verse;
        }



        // The method is returning the value of the private field `_verse`, which contains the words of a scripture.
        public string GetScriptureWords()
        {            
            return _verse;
        }


       
        /* The function checks if all the words in a list are equal to "____" and returns true if they are. 
        A boolean value is being returned. It will be true if all the words in the `_wordList` are
        equal to "____" and false if at least one word is not equal to "____". */
        public bool IsCompletlyHidden()
        {    
            foreach (string word in _wordList)
            {
                if (word != "____")
                {
                    return false;
                }   
            }
            return true;
        }



        /* This function returns a random index within a specified range and returns the randomly 
        generated index.*/
        public int GetRandomIndex()
        {
            Random rand = new Random();
            _index = rand.Next(0, _numIndex.Count);
            return _index;
        } 


        
        /* If the condition `_numIndex.Count == 0` is true, then the method `IsCompletlyHidden()` is called and
        nothing is returned. Otherwise, if the condition is false, then the method removes an element from
        the `_numIndex` list at the specified index `_index` and replaces the corresponding word in the
        `_wordList` with "____". Nothing is explicitly returned in this.*/
        public void HideWord()
        {
            if (_numIndex.Count == 0)
            {
                IsCompletlyHidden();
                return;
            }
            
            _index = GetRandomIndex();
            
            _wordList[_numIndex[_index]] = "____"; 
            _numIndex.RemoveAt(_index);   
        }



        
        /* This function splits a given verse into a list of words and assigns each word a numerical index.
        Additionally, a parallel list of index values is created to control the random hiding so that a 
        word will always be removed.*/
        public void SplitVerseIntoList()
        {  
            _wordList = new List<string>();
            _numIndex = new List<int>();

            int value = 0;
            string[] scriptText = _verse.Split(' ');

            foreach (string word in scriptText)
            {
            _wordList.Add(new string(word));
            _numIndex.Add(value);
            value++;
            }
        }          

        
        
        /* The method `GetHiddenVerse()` returns a string that represents the hidden verse, where each
        word is replaced with underscores.*/
        public string GetHiddenVerse()
        {
            HideWord(); 
            string hiddenVerse = string.Join(" ", _wordList);
            return hiddenVerse;
        }        




        // The function displays a hidden verse.
        public void DisplayRenderHidden()
        {
            WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n");
            WriteLine(GetHiddenVerse());
            WriteLine("\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        }



        // This function continues a loop that hides a word, clears the screen, and displays the hidden word.
        public void ContinueHideLoop()
        {          
                HideWord();
                Clear();
                DisplayRenderHidden();
        }
    }
}

