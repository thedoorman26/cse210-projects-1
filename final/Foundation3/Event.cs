using System;
using System.IO;
using System.Collections.Generic;
using static System.Console;

namespace Foundation3
{

    public abstract class Event
    {
        protected string _eventTitle;
        protected string _description;
        protected DateTime _date;
        protected TimeSpan _time;
        protected Address _address;

        public Event(string title, string description, DateTime date, TimeSpan time, Address address)
        {
            _eventTitle = title;
            _description = description;
            _date = date;
            _time = time;
            _address = address;
        } 

        public string DisplayTimeFrame()
        {
            DateTime startTime = _date;
            TimeSpan timeFrame = _time;

            DateTime endTime = startTime + timeFrame; // Calculate end time based on time frame

            string eventTime =(startTime.ToString("h:mm tt") + " - " + endTime.ToString("h:mm tt"));

            return eventTime;
        }

        public string StandardDetails()
        {
            string standard = ($"Title: {_eventTitle}\nDescription: {_description}\nDate: {_date.ToShortDateString()}\nTime: {DisplayTimeFrame()}\nAddress: {_address.GetAddress()}");
            return standard;
        }

        public abstract string FullDetails();
        

        public string ShortDescription()
        {
            string shortDetails = ($"Eventy Type: {GetType().Name}\nEvent Title: {_eventTitle}\nDate: {_date.ToShortDateString()}\n");
            return shortDetails;
        }
    }
}