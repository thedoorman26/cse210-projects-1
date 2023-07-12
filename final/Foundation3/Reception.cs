using System;
using System.IO;
using System.Collections.Generic;
using static System.Console;

namespace Foundation3
{

    class Reception : Event
    {
       private string _rsvp;

       public Reception(string title, string description, DateTime date, TimeSpan time, Address address, string rsvp) :base(title, description, date, time, address)
       {
            _rsvp = rsvp;
       }

       public override string FullDetails()
        {
            string full = ($"Title: {_eventTitle}\nDescription: {_description}\nDate: {_date.ToShortDateString()}\nTime: {DisplayTimeFrame()}\nAddress: {_address.GetAddress()}\nPlease RSVP To: {_rsvp}");
            return full;
            
        }
    }
}