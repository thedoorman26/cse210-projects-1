using System;
using System.IO;
using System.Collections.Generic;
using static System.Console;
using System.Text;

namespace Foundation4
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("\nHello Foundation 4 World!\n");

            List<Activity> _activities = new List<Activity>();

            Swimming swimming = new Swimming(DateTime.Now, 45, 50, 20);
            _activities.Add(swimming);
            Running running= new Running(DateTime.Now, 40, 3);
            _activities.Add(running);
            Cycling cycle = new Cycling(DateTime.Now, 65, 9.5);
            _activities.Add(cycle);


            foreach (Activity a in _activities)
            {
                WriteLine("");
                WriteLine(a.GetSummary());
                WriteLine("");
            }
            
        }
    }
}