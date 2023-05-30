using System;
using static System.Console;

namespace Homework
{
    class WritingAssignment : Assignment
    {
        private string _title;

        public WritingAssignment(string name, string topic, string title) : base(name, topic)
        {
            _title = title;
        }

        public string GetWritingInformation()
        {
            return ($"Student Name: {_studentName}, Topic: {_topic}\nTitle: {_title}");
        }
    }
}