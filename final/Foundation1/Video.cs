using System;
using static System.Console;

namespace Foundation1
{
    class Video
    {
        private string _title;
        private string _author;
        private int _length;

        public List<Comment> _comments = new List<Comment>();


        public Video(string title, string author, int length)
        {
            _title = title;
            _author = author;
            _length = length;        
        }


        public void AddComment(string name, string text)
        {
            Comment comment = new Comment(name, text);
            _comments.Add(comment);
        }


        public int GetNumOfComments()
        {
            return _comments.Count();
        }


        public void DisplayVideo()
        {
            WriteLine($"\nTitle: {_title}");
            WriteLine($"Author: {_author}");
            WriteLine($"Video Length: {_length}");
            WriteLine($"Number of Comments: {GetNumOfComments()}");
        }
    }
}
