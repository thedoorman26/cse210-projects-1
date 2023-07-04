using System;
using System.IO;
using System.Collections.Generic;
using static System.Console;


namespace Foundation2
{
    class Address
    {
        //Private attributes for the address class
        private string _street;
        private string _city;
        private string _state;
        private string _zipcode;
        private string _country;

        
        //Constructor for the address class
        public Address(string street, string city, string state, string zipcode, string country)
        {
            _street = street;
            _city = city;
            _state = state;
            _zipcode = zipcode;
            _country = country;
        }


        //Method to check if address in USA
        public bool InUsa()
        {
            if (_country == "USA")
            {
                return true;
            }
            else return false;
        }


        //Method to return an address string
        public string GetAddress()
        {
            return ($"   {_street}\n   {_city}, {_state} {_zipcode}\n   {_country}");
        }
    }
}