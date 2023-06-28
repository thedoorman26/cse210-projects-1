using System;
using System.IO;
using System.Collections.Generic;
using static System.Console;


namespace Foundation2
{
    class Customer
    {
        private string _name;

        private Address _address;

        public Customer(string name, Address address)
        {
            _name = name;
            _address = address;
        }

        public string GetName()
        {
            return _name;
        }
        public bool CheckCountry()
        {
            return _address.InUsa();
        }

        public string GetCustomerAddress()
        {
            string custAddress = _address.GetAddress();
            return custAddress;
        }

        
    }
}