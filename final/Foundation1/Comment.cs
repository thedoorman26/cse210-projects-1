using System;
using static System.Console;

namespace Foundation1
{

    class Comment
    {
        private string _name;
        private string _text;

        public Comment(string name, string text)
        {
            _name = name;
            _text = text;
        }

        public void DisplayComments()
        {
            WriteLine($"Name: {_name} \n  '{_text}'");
        }

    }
}
