using System;
using static System.Console;
namespace ScriptureMemorization
{
    // Reference class represents the scripture reference
    class Reference
    {
        //Private variables to track reference attributes in the class
        private string _book;
        private int _chapter;
        private int _verse;
        private int _endVerse;


        //Public array to hold reference variables with one verse
        public Reference(string book, int chapter, int verse)
        {
            _book = book;
            _chapter = chapter;
            _verse = verse;
        }


        //Public array to hold reference variables with multiple verses
        public Reference(string book, int chapter, int verse, int endVerse)
        {
            _book = book;
            _chapter = chapter;
            _verse = verse;
            _endVerse = endVerse;
        }

        
        //Method to put reference parts together into a string
        public string GetReference() 
        {
            string reference = ($"{_book} {_chapter}:{_verse} ");
            return reference;
        }


        //Method to display the reference string
        public void DisplayReference()
        {
            Console.Write(GetReference());
        }
        
    }
}
