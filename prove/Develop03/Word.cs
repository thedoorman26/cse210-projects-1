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
        assigns it to the private field `_verse`. */
        public Word(string verse)
        {
            _verse = verse;
        }


        // The method is returning the value of the private field `_verse`, which contains the words of a scripture.
        public string GetScriptureWords()
        {            
            return _verse;
        }

        
        /* The method is returning a boolean value. If the `_numIndex` list is empty, it returns `true`,
        otherwise it returns `false`.*/   
        public bool IsCompletlyHidden()
        {    
            if (_numIndex.Count == 0)
            {
                return true;
            }
            return false;
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
        nothing is returned. */ /* If the condition is false, then the method removes an element from
        the `_numIndex` list at the specified index `_index`  Nothing is explicitly returned in this.*/
        public void HideWord()
        {
            if (_numIndex.Count == 0)
            {
                IsCompletlyHidden();
                return;
            }
            
            _index = GetRandomIndex();

            /* If the condition is false, then the method removes an element from
            the `_numIndex` list at the specified index `_index` and replaces the corresponding word in the
            `_wordList` by concatinating the first letter with "____" (leaving the first letter as a hint).*/
            _wordList[_numIndex[_index]] = _wordList[_numIndex[_index]][0] + "____"; 
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
            string hiddenVerse = string.Join(" ", _wordList);
            return hiddenVerse;
        }        


        // This function continues a loop that hides 3 words, clears the screen.
        public void ContinueHideLoop()
        {          
            HideWord();
            HideWord();
            HideWord();
        }
    }
}

