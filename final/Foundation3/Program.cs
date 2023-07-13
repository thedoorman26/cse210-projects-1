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
            //Change background and foreground colors
            BackgroundColor = ConsoleColor.DarkCyan;
            ForegroundColor = ConsoleColor.Yellow;
            Clear();

            //List to track all the events
            List<Event> _events = new ();


            //Intro to the program
            WriteLine("\nEvent Planning Program!\n");


            //Pause to allow user to see information
            WriteLine("Press any key to see details by event type...");
            ReadKey();


            //Events instances to add info to the program
            Address address1 = new ("7904 Phoenix Pass", "Austin", "TX", 78737);
            Reception reception = new ("Brown-Stevens Wedding", "Wedding Reception for Lacey Brown and Ben Stevens", new DateTime (2023, 12, 04, 19, 0, 0), new TimeSpan(2, 30, 0), address1, "eventrsvp@gmail.com");        
            _events.Add(reception);
            Address address2 = new ("5678 Bountiful Place", "St. George", "UT", 84502);
            Lecture lecture = new ("How to Be Successful in College", "Lecture on setting good habits and schedules for college life.", new DateTime (2023, 8, 30, 17, 30, 0), new TimeSpan(1, 0, 0), address2, "President Successful",50);
            _events.Add(lecture);
            Address address3 = new ("2479 Jump Street", "Boise", "ID", 83701);
            OutdoorGathering gathering = new ("Summer Gala", "Celebrate the beginning of Summer with a Party", new DateTime (2024, 6, 1, 10, 0, 0), new TimeSpan (3, 00, 0), address3, "Sunny with a gentle breeze");
            _events.Add(gathering);

            
            //Iterate through the list to display different length media messages
            foreach (Event e in _events)
            {
                Clear();
                WriteLine("");
                WriteLine($"{e.GetType().Name}");
                WriteLine("\nStandard Description:\n");
                WriteLine(e.StandardDetails());
                WriteLine("\n\nFull Description:\n");

                WriteLine(e.FullDetails());
                WriteLine("\n\nShort Description:\n");
                WriteLine(e.ShortDescription());

                //Pause between each type of event
                WriteLine("\nPress any key to see next event...");
                ReadKey();
            }
        }
    }
}