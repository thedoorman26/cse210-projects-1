using System;
using static System.Console;

namespace Homework
{
    public class MathAssignment : Assignment
    {
        private string _textbookSection;
        private string _problems;

        public MathAssignment(string name, string topic, string book, string problems) : base(name, topic)
        {
            _textbookSection = book;
            _problems = problems;
        }

        public string GetHomeworkList()
        {
            return ($"Student Name: {_studentName}, Topic: {_topic}\nChapter: {_textbookSection}, Problems: {_problems} ");
        }
    }
}