using System;
using System.IO;
using System.Collections.Generic;
using static System.Console;

namespace Foundation3
{
    /// <summary>
    /// 
    /// </summary>
    class Lecture : Event
    {
        private string _speaker;
        private int _capacity;

        public Lecture(string title, string description, DateTime date, TimeSpan time, Address address, string speaker, int capacity) :base(title, description, date, time, address)
        {
            _speaker = speaker;
            _capacity = capacity;
        }

        public override string FullDetails()
        {
            string full = ($"Title: {_eventTitle}\nSpeaker: {_speaker}\nDescription: {_description}\nDate: {_date.ToShortDateString()}\nTime: {DisplayTimeFrame()}\nCapacity: {_capacity}\nAddress: {_address.GetAddress()}");
            return full;
            
        }
    }
}