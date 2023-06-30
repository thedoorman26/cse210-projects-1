using System;
using System.IO;
using System.Collections.Generic;
using static System.Console;

namespace Foundation3
{

    class Event
    {
        private string _eventTitle;
        private string _description;
        DateTime _date;
        TimeSpan _time;
        Address _address;

        public Event(string title, string description, DateTime date, TimeSpan time, Address address)
        {
            _eventTitle = title;
            _description = description;
            _date = date;
            _time = time;
            _address = address;
        } 

        public string StandardDetails()
        {
            string standard = ($"Title: {_eventTitle}\nDescription: {_description}\nDate: {_date.ToShortDateString}\nTime: {_time}\nAddress:\n{_address.GetAddress()}");
            return standard;
        }

        public string FullDetails()
        {
            return "";
        }

        public string ShortDescription()
        {
            return "";
        }
    }
}