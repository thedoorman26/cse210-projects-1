using System;
using System.IO;
using System.Collections.Generic;
using static System.Console;

namespace Foundation3
{
    class OutdoorGathering : Event
    {
        //Private attributes of the OutdoorGathering class
        private string _weather;


        //Constructor for the OutdoorGathering class
        public OutdoorGathering(string title, string description, DateTime date, TimeSpan time, Address address, string weather) :base(title, description, date, time, address)
        {
            _weather = weather;
        }


        //Method to override the parent class and display the full details of this class
        public override string FullDetails()
        {
            string full = ($"Event Type: {GetType().Name}\nTitle: {_eventTitle}\nDescription: {_description}\nDate: {_date.ToShortDateString()}\nTime: {DisplayTimeFrame()}\nExpected Weather: {_weather}\nAddress: {_address.GetAddress()}");
            return full;            
        }
    }
}