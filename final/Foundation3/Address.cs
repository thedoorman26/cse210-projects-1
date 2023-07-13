using System;
using System.IO;
using System.Collections.Generic;
using static System.Console;

namespace Foundation3
{
    public class Address
    {
        //Private attributes for the Address class
        private string _street;
        private string _city;
        private string _state;
        private int _zipcode;


        //Constructor for the Address class
        public Address(string street, string city, string state, int zipcode)
        {
            _street = street;
            _city = city;
            _state = state;
            _zipcode = zipcode;          
        } 


        //Method to get and display the address
        public string GetAddress()
        {
            return ($"{_street}, {_city}, {_state} {_zipcode}");
        }
    }
}