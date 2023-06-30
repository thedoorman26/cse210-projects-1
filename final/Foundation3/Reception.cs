using System;
using System.IO;
using System.Collections.Generic;
using static System.Console;

namespace Foundation3
{

    class Reception : Event
    {
       private bool _rsvp;

       public Reception(string title, string description, DateTime date, TimeSpan time, Address address, bool rsvp) :base(title, description, date, time, address)
       {
            _rsvp = rsvp;
       }
    }
}