using System;
using System.IO;
using System.Collections.Generic;
using static System.Console;

namespace Foundation3
{

    class OutdoorGathering : Event
    {
        private string _weather;

        public OutdoorGathering(string title, string description, DateTime date, TimeSpan time, Address address, string weather) :base(title, description, date, time, address)
        {
            _weather = weather;
        }

        public override string FullDetails()
        {
            string full = ($"Title: {_eventTitle}\n\nDescription: {_description}\nDate: {_date.ToShortDateString()}\nTime: {DisplayTimeFrame()}\nExpected Weather: {_weather}\nAddress: {_address.GetAddress()}");
            return full;
            
        }
    }
}