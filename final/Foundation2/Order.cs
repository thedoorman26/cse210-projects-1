using System;
using System.IO;
using System.Collections.Generic;
using static System.Console;


namespace Foundation2
{
    class Order
    {
        List<Product> _products = new List<Product>();
        private Customer customer;

        public Order()
        {

        }

        public void AddProducts(Product product)
        {
            _products.Add(product);
        }

        public string MakeShippingLabel()
        {
            return "";
        }

        public string MakePackingLabel()
        {
            return "";
        }

        public int GetShippingCost()
        {
            
            return 5;
        }

        public double TotalPurchasePrice()
        {
            return 0;
        }
    }
}