using System;
using System.IO;
using System.Collections.Generic;
using static System.Console;


namespace Foundation2
{
    class Address
    {
        private string _street;
        private string _city;
        private string _state;
        private int _zipcode;
        private string _country;

        public Address()
        {

        }

        public bool InUsa()
        {
            if (_country == "USA")
            {
                return true;
            }
            else return false;
        }

        public void GetAddress()
        {
            WriteLine($"{_street}\n{_city}, {_state} {_zipcode}\n{_country}");
        }
    }
}