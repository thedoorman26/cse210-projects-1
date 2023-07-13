using System;
using System.IO;
using System.Collections.Generic;
using static System.Console;
using System.Text;

namespace Foundation4
{
    /*For creativity I added color and wait key pauses so that the information can be viewed per exercise that is tracked.  I formatted the data 
    as instructed, but kept the practice of wait key so the data didn't just fly by and the program end.
    */
    class Program
    {
        static void Main(string[] args)
        {
            //Change Background and Foreground colors
            BackgroundColor = ConsoleColor.Green;
            ForegroundColor = ConsoleColor.Gray;
            Clear();


            //Display Intro Message
            WriteLine("\nExercise Tracking Program!\n");
            WriteLine("Press any key to see exercise tracking info...");
            ReadKey();


            //List to track activity information
            List<Activity> _activities = new List<Activity>();


            //Exercise activity instances for each category
            Swimming swimming = new Swimming(new DateTime(2023, 06, 30), 35, 50);
            _activities.Add(swimming);
            Running running= new Running(new DateTime(2023, 7, 5), 30, 3);
            _activities.Add(running);
            Cycling cycle = new Cycling(new DateTime(2023, 7, 12), 65, 9.5);
            _activities.Add(cycle);



            //Iterate through activity list and display the summary info
            foreach (Activity a in _activities)
            {
                WriteLine("");
                WriteLine(a.GetSummary());
                WriteLine("");

                //Pause that allows user to look at each set of info
                WriteLine("Press any key to see next tracking info...");
                ReadKey();
            }            
        }
    }
}