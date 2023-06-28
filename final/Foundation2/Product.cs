using System;
using System.IO;
using System.Collections.Generic;
using static System.Console;


namespace Foundation2
{
    class Product
    {
        public string _productName{get; private set;}
        public int _productId{get; private set;}
        private double _price;
        private int _quantity;


        public Product(string name, int number, double price, int qty)
        {
            _productName = name;
            _productId = number;
            _price = price;
            _quantity = qty;

        }

        public double CalculateProductPrice()
        {
            double cost = _price * _quantity;
            return cost;
        }

        public string GetProdName()
        {
            return _productName;
        }

        public int GetProdId()
        {
            return _productId;
        }
    }
}