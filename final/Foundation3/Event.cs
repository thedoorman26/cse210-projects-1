using System;
using System.IO;
using System.Collections.Generic;
using static System.Console;

namespace Foundation3
{

    public abstract class Event
    {
        //Protected attributes for the Event class and it's child classes
        protected string _eventTitle;
        protected string _description;
        protected DateTime _date;
        protected TimeSpan _time;
        protected Address _address;


        public Event()
        {

        }


        //Contructor for the Event class
        public Event(string title, string description, DateTime date, TimeSpan time, Address address)
        {
            _eventTitle = title;
            _description = description;
            _date = date;
            _time = time;
            _address = address;
        } 


        //Method for displaying time frame in the desired format
        public string DisplayTimeFrame()
        {
            DateTime startTime = _date;
            TimeSpan timeFrame = _time;

            DateTime endTime = startTime + timeFrame; // Calculate end time based on time frame

            string eventTime =(startTime.ToString("h:mmtt") + " - " + endTime.ToString("h:mmtt"));

            return eventTime;
        }


        //Method to display standard details for events
        public string StandardDetails()
        {
            string standard = ($"Title: {_eventTitle}\nDescription: {_description}\nDate: {_date.ToShortDateString()}\nTime: {DisplayTimeFrame()}\nAddress: {_address.GetAddress()}");
            return standard;
        }


        //Abstract method so each child class can display specific info related to their event
        public abstract string FullDetails();
        //{
            
            // if  (eventDetailed == "Lecture")
            // {
            //     Lecture fullLect = new Lecture();
            //     string fullLecture = fullLect.LectureFullDetails();
            //     // string fullLecture = ($"Event Type: {GetType().Name}\nTitle: {_eventTitle}\nSpeaker: {fullLect.GetSpeaker()}\nDescription: {_description}\nDate: {_date.ToShortDateString()}\nTime: {DisplayTimeFrame()}\nCapacity: {_events.GetCapacity()}\nAddress: {_address.GetAddress()}");
            //     return fullLecture;
            // }
            // else if (eventDetailed == "Reception")
            // {
            //     Reception fullRecep = new Reception();
            //     string fullReception = ($"Event Type: {GetType().Name}\nTitle: {_eventTitle}\nDescription: {_description}\nDate: {_date.ToShortDateString()}\nTime: {DisplayTimeFrame()}\nAddress: {_address.GetAddress()}\nPlease RSVP To: {fullRecep.GetRSVP()}");
            //     return fullReception;
            // }
            // else
            // {
            //     OutdoorGathering fullOut = new OutdoorGathering();
            //     string fullOutdoor = ($"Event Type: {GetType().Name}\nTitle: {_eventTitle}\n\nDescription: {_description}\nDate: {_date.ToShortDateString()}\nTime: {DisplayTimeFrame()}\nExpected Weather: {fullOut.GetWeather()}\nAddress: {_address.GetAddress()}");
            //     return fullOutdoor;
            // }
        //}
        

        //Method to display short details about an event
        public string ShortDescription()
        {
            string shortDetails = ($"Eventy Type: {GetType().Name}\nEvent Title: {_eventTitle}\nDate: {_date.ToShortDateString()}\n");
            return shortDetails;
        }
    }
}