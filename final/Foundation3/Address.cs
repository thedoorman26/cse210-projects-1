using System;
using System.IO;
using System.Collections.Generic;
using static System.Console;

namespace Foundation3
{

    public class Address
    {
        private string _street;
        private string _city;
        private string _state;
        private int _zipcode;

        public Address(string street, string city, string state, int zipcode)
        {
            _street = street;
            _city = city;
            _state = state;
            _zipcode = zipcode;          
        } 

        public string GetAddress()
        {
            return ($"{_street}, {_city}, {_state} {_zipcode}");
        }
    }
}