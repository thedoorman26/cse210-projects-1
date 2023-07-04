using System;
using static System.Console;

namespace Foundation1
{

    class Comment
    {
        //Private attributes for comment info
        private string _name;
        private string _text;


        //Constructor for the comment class
        public Comment(string name, string text)
        {
            _name = name;
            _text = text;
        }


        //Method to display comment info
        public void DisplayComments()
        {
            WriteLine($"Name: {_name} \n  '{_text}'");
        }

    }
}
