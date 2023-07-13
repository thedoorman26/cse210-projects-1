using System;
using System.IO;
using System.Collections.Generic;
using static System.Console;

namespace Foundation3
{

    class Reception : Event
    {
        //Private attributes for the Reception class
        private string _rsvp;


        //Constructor for the Recpetion class
        public Reception(string title, string description, DateTime date, TimeSpan time, Address address, string rsvp) :base(title, description, date, time, address)
        {
                _rsvp = rsvp;
        }


        //Method to override the parent class and display details that include attributes specific to this class
        public override string FullDetails()
        {
            string full = ($"Event Type: {GetType().Name}\nTitle: {_eventTitle}\nDescription: {_description}\nDate: {_date.ToShortDateString()}\nTime: {DisplayTimeFrame()}\nAddress: {_address.GetAddress()}\nPlease RSVP To: {_rsvp}");
            return full;
            
        }
    }
}