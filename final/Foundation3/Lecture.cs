using System;
using System.IO;
using System.Collections.Generic;
using static System.Console;

namespace Foundation3
{

    class Lecture : Event
    {
        private string _speaker;
        private int _capacity;

        public Lecture(string title, string description, DateTime date, TimeSpan time, Address address, string speaker, int capacity) :base(title, description, date, time, address)
        {
            _speaker = speaker;
            _capacity = capacity;
        }
    }
}