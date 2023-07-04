using System;
using System.IO;
using System.Collections.Generic;
using static System.Console;


namespace Foundation2
{
    class Order
    {
        //Attribute for Order class and a list for Products
        List<Product> _products = new List<Product>();
        private Customer _customer;
        
        
        //Constructor for Order class
        public Order(Customer customer)
        {
            _customer = customer;
        }

        
        //Method to add products to list
        public void AddProducts(string name, int id, double price, int qty)
        {
            Product product = new Product(name, id, price, qty);
            _products.Add(product);
        }


        //Method to display the shipping label info
        public string MakeShippingLabel()
        {
            string shipLabel = ($"   {_customer.GetName()}\n{_customer.GetCustomerAddress()}\n");
            return shipLabel;
        }

        
        //Method to display packing label info
        public string MakePackingLabel()
        {
            string prodLabel = "";
            foreach (Product p in _products)
            {
                prodLabel += ($"   Product ID: {p.GetProdId()} -- {p.GetProdName()}\n");
            }
            return prodLabel;
        }


        //Method to set the shipping cost based on country status
        public int GetShippingCost()
        {
            if (_customer.CheckCountry())
            {
                return 5;
            }

            else
                return 35;                
        }


        //Method to calculate total order price
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