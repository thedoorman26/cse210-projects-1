using System;
using System.IO;
using System.Collections.Generic;
using static System.Console;


namespace Foundation2
{
    /*For creativity I added color, formatted the shipping and product labels to indent for easier reading and identification.  I also added quantity to the 
    packing label since that is needed for packing.
    */
    class Program
    {
        static void Main(string[] args)
        {
            //Change program colors
            BackgroundColor = ConsoleColor.DarkGray;
            ForegroundColor = ConsoleColor.DarkYellow;
            Clear();


            //Welcome message
            WriteLine("\nOnline Ordering Program!\n");
            WriteLine("Press any key to continue...");
            ReadKey();      


            //Add first customer order
            Address address1 = new Address("1234 Question St.", "Spring", "UT", "84201", "USA");
            Customer customer1 = new Customer("Norma Bridge", address1);
            Order order1 = new Order(customer1);
            order1.AddProducts("Soda", 2319, 2.50, 6);
            order1.AddProducts ("Candybar", 2589, 1.75, 3);
            order1.AddProducts("Milk", 4712, 3.75, 2);
            order1.AddProducts("Bread", 3597, 2.98, 3);


            //Add second customer order
            Address address2 = new Address("720 E Railway St.", "Raymond", "AB", "T0K 2S0", "CANADA");
            Customer customer2 = new Customer("Meg Larson", address2);
            Order order2 = new Order(customer2);
            order2.AddProducts("Pancake Mix", 1489, 3.99, 4);
            order2.AddProducts("Oil", 1264, 2.80, 2);
            order2.AddProducts("Milk", 4712, 3.75, 3);
            order2.AddProducts("Dzn Eggs", 3190, 3.25, 2);


            //Create a list to hold orders
            List<Order> _orders = new List<Order>{order1, order2};

            //Iterate through the list of orders to display shipping and product labels with a total cost
            int i = 1;
            foreach (Order o in _orders)
            {
                Clear();
                WriteLine($"Order #{i}\n");
                i += 1;
                WriteLine($"Shipping Label:\n\n{o.MakeShippingLabel()}\n");
                WriteLine($"Packaging Label:\n\n{o.MakePackingLabel()}");
                WriteLine($"Order Total: ${o.TotalPurchasePrice()}");
                WriteLine("\nPress any key for next order...");   
                ReadKey();            
            }


            //Closing message
            WriteLine("\nThanks for using the Online Ordering System!!\n");

        }
    }
}