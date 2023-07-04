using System;
using System.IO;
using System.Collections.Generic;
using static System.Console;


namespace Foundation2
{
    class Customer
    {
        //private attributes for the Customer class
        private string _name;
        private Address _address;


        //Constructor for the customer class
        public Customer(string name, Address address)
        {
            _name = name;
            _address = address;
        }

        
        //Method to get customer name
        public string GetName()
        {
            return _name;
        }


        //Check country method
        public bool CheckCountry()
        {
            return _address.InUsa();
        }


        //Method to return customer address string
        public string GetCustomerAddress()
        {
            string custAddress = _address.GetAddress();
            return custAddress;
        }        
    }
}