using System;
using System.IO;
using System.Collections.Generic;
using static System.Console;
using System.Text;

namespace Foundation3
{

    class Program
    {
        static void Main()
        {
            BackgroundColor = ConsoleColor.DarkCyan;
            ForegroundColor = ConsoleColor.Yellow;
            Clear();

            List<Event> _events = new ();

            Console.WriteLine("\nHello Event Planning World!\n");

            WriteLine("Press any key when ready...");
            ReadKey();

            Address address1 = new ("7904 Phoenix Pass", "Austin", "TX", 78737);
            Reception reception = new ("Brown-Stevens Wedding", "Wedding Reception for Lacey Brown and Ben Stevens", DateTime.Now, TimeSpan.MaxValue, address1, true);        
            _events.Add(reception);
            Address address2 = new ("5678 Bountiful Place", "St. George", "UT", 84502);
            Lecture lecture = new ("How to Be Successful in College", "Lecture on setting good habits and schedules for college life.", DateTime.Now, TimeSpan.MaxValue, address2, "President Successful",50);
            _events.Add(lecture);
            Address address3 = new ("2479 Jump Street", "Boise", "ID", 83701);
            OutdoorGathering gathering = new ("Summer Gala", "Celebrate the beginning of Summer with a Party", DateTime.Now, TimeSpan.MaxValue, address3, "Sunny with a gentle breeze");
            _events.Add(gathering);

            
            foreach (Event e in _events)
            {
                WriteLine("");
                WriteLine($"Event Type: {e.GetType().Name}");
                WriteLine(e.StandardDetails());

                WriteLine("Press any key when ready...");
                ReadKey();
            }


        }
    }
}