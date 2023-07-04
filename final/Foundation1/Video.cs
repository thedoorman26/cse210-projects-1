using System;
using static System.Console;

namespace Foundation1
{
    class Video
    {
        //private attributes for the video class
        private string _title;
        private string _author;
        private int _length;

        
        //List to store comment info
        public List<Comment> _comments = new List<Comment>();


        //Constructor for the Video class
        public Video(string title, string author, int length)
        {
            _title = title;
            _author = author;
            _length = length;        
        }


        //Method to add comments to the commet List
        public void AddComment(string name, string text)
        {
            Comment comment = new Comment(name, text);
            _comments.Add(comment);
        }


        //Method to get the comment count of a video comment list
        public int GetNumOfComments()
        {
            return _comments.Count();
        }


        //Method to display the video info and # of comments
        public void DisplayVideo()
        {
            WriteLine($"\nTitle: {_title}");
            WriteLine($"Author: {_author}");
            WriteLine($"Video Length: {_length}");
            WriteLine($"Number of Comments: {GetNumOfComments()}");
        }
    }
}
