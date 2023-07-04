using System;
using System.IO;
using System.Collections.Generic;
using static System.Console;


namespace Foundation2
{
    class Order
    {
        List<Product> _products = new List<Product>();
        private Customer _customer;

        public Order(Customer customer)
        {
            _customer = customer;
        }

        public void AddProducts(string name, int id, double price, int qty)
        {
            Product product = new Product(name, id, price, qty);
            _products.Add(product);
        }

        public string MakeShippingLabel()
        {
            string shipLabel = ($"   {_customer.GetName()}\n{_customer.GetCustomerAddress()}\n");
            return shipLabel;
        }

        public string MakePackingLabel()
        {
            string prodLabel = "";
            foreach (Product p in _products)
            {
                prodLabel += ($"   Product ID: {p.GetProdId()} -- {p.GetProdName()}\n");
            }
            return prodLabel;
        }

        public int GetShippingCost()
        {
            if (_customer.CheckCountry())
            {
                return 5;
            }

            else
                return 35;                
        }

        public double TotalPurchasePrice()
        {
            double total = 0;

            foreach (Product p in _products)
            {
                total += p.CalculateProductPrice();
            }
            total += GetShippingCost();
            return total;
        }
    }
}