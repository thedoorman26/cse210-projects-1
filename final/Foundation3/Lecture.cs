using System;
using System.IO;
using System.Collections.Generic;
using static System.Console;

namespace Foundation3
{
    class Lecture : Event
    {
        //Private attributes of the Lecture class
        private string _speaker;
        private int _capacity;


        //Constructor for the lecture class
        public Lecture(string title, string description, DateTime date, TimeSpan time, Address address, string speaker, int capacity) :base(title, description, date, time, address)
        {
            _speaker = speaker;
            _capacity = capacity;
        }


       //Display method for the full details.
        public override string FullDetails()
        {
            string full = ($"Event Type: {GetType().Name}\nTitle: {_eventTitle}\nSpeaker: {_speaker}\nDescription: {_description}\nDate: {_date.ToShortDateString()}\nTime: {DisplayTimeFrame()}\nCapacity: {_capacity}\nAddress: {_address.GetAddress()}");
            return full;            
        }


    }
}