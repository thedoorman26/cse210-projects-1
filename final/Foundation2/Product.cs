using System;
using System.IO;
using System.Collections.Generic;
using static System.Console;


namespace Foundation2
{
    class Product
    {
        private string _productName;
        private int _productId;
        private double _price;
        private int _quantity;

        public Product()
        {

        }

        public double TotalProductPrice()
        {
            double cost = _price * _quantity;
            return cost;
        }
    }
}