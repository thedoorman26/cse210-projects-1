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
        private string _zipcode;
        private string _country;

        public Address(string street, string city, string state, string zipcode, string country)
        {
            _street = street;
            _city = city;
            _state = state;
            _zipcode = zipcode;
            _country = country;
        }

        public bool InUsa()
        {
            if (_country == "USA")
            {
                return true;
            }
            else return false;
        }

        public string GetAddress()
        {
            return ($"   {_street}\n   {_city}, {_state} {_zipcode}\n   {_country}");
        }
    }
}