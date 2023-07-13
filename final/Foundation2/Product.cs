using System;
using System.IO;
using System.Collections.Generic;
using static System.Console;


namespace Foundation2
{
    class Product
    {
        //Private attributes for the product class
        private string _productName;
        private int _productId;        
        private double _price;
        private int _quantity;


        //Constructor for the product class
        public Product(string name, int number, double price, int qty)
        {
            _productName = name;
            _productId = number;
            _price = price;
            _quantity = qty;
        }

        
        //Method to calculate product price using price and qty
        public double CalculateProductPrice()
        {
            double cost = _price * _quantity;
            return cost;
        }


        //Method to return product Name
        public string GetProdName()
        {
            return _productName;
        }


        //Method to return product ID
        public int GetProdId()
        {
            return _productId;
        }


        //Method to return product Qty
        public int GetProdQty()
        {
            return _quantity;
        }
    }
}