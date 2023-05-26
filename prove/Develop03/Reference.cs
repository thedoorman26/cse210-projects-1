using System;
using static System.Console;
namespace ScriptureMemorization
{
    // Reference class stores and handles the scripture reference only.
    class Reference
    {    
        /* These are private variables in the `Reference` class that are used to track the attributes of a
        scripture reference, such as the book, chapter, verse, and end verse. They are only accessible
        within the `Reference` class and cannot be accessed or modified outside of it. */
        private string _book;
        private int _chapter;
        private int _verse;
        private int _endVerse;


       
        /* This is a constructor for the `Reference` class that takes three parameters: `book`, `chapter`, and
        `verse`. It initializes the private variables `_book`, `_chapter`, `_verse`, and `_endVerse` with
        the values passed in as arguments. This constructor is used to create a `Reference` object that
        represents a scripture reference with one verse. The `_endVerse` variable is set to 0 to indicate
        that this reference only has one verse. */
        public Reference(string book, int chapter, int verse)
        {
            _book = book;
            _chapter = chapter;
            _verse = verse;
            _endVerse = 0;
        }


        
        /* This is a constructor for the `Reference` class that takes four parameters: `book`, `chapter`,
        `verse`, and `endVerse`. It initializes the private variables `_book`, `_chapter`, `_verse`, and
        `_endVerse` with the values passed in as arguments. This constructor is used to create a `Reference`
        object that represents a scripture reference with multiple verses. */
        public Reference(string book, int chapter, int verse, int endVerse)
        {
            _book = book;
            _chapter = chapter;
            _verse = verse;
            _endVerse = endVerse;
        }

        

        /* The method `GetReference()` returns a string that represents a scripture reference. The format of the
        string depends on the values of the `_book`, `_chapter`, `_verse`, and `_endVerse` variables. If
        `_endVerse` is 0, the string will be in the format of "{_book} {_chapter}:{_verse} ". If `_endVerse`
        is not 0.*/
        public string GetReference() 
        {   
            string reference = "";
            if (_endVerse == 0)
            {
                reference = ($"{_book} {_chapter}:{_verse} ");                
            }
            else
            {
                reference = ($"{_book} {_chapter}:{_verse}-{_endVerse} ");
            }
            return reference;
        }    
    }
}
