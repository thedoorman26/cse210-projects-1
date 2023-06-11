using System;
using static System.Console;

namespace Mindfulness
{
    class ListingActivity : Activity
    {
        //Private lists to store and display user answers
        private List<string> _listingPrompt;
        private List<string> _listedItems;


        //Constructor to hold the lists for the class and variables from the parent class
        public ListingActivity(string activity, string description) : base(activity, description)
        {
            _listingPrompt = new List<string>();
            _listedItems = new List<string>();
        }


        // This function creates a list of prompts for a listing activity.
        private void CreateListingPrompts()
        {
            _listingPrompt.Add(new string("Who are people that you appreciate?"));
            _listingPrompt.Add(new string("What are personal strengths of yours?"));
            _listingPrompt.Add(new string("Who are people that you have helped this week?"));
            _listingPrompt.Add(new string("When have you felt the Holy Ghost this month?"));
            _listingPrompt.Add(new string("Who are some of your personal heroes?"));
            _listingPrompt.Add(new string("What miracles have you seen in your life?"));
        }


        /* The function displays a randomly selected listing prompt and prompts the user to press any
        key to begin.*/
        public void DisplayListingPrompt()
        {
            CreateListingPrompts();
            ForegroundColor = ConsoleColor.DarkCyan;
            WriteLine($"\n**Listing Prompt: {_listingPrompt[GetRandomPromptIndex(_listingPrompt.Count)]}**");
            ForegroundColor = ConsoleColor.Blue;
            WriteLine("\nPress any key to begin...");
            ReadKey();
            PauseTime("Get Ready to List... ");
        }
       
       
        // The function adds a user-inputted item to a list.
        public void KeepListing()
        {
            WriteLine("");
            Write("List Item: ");
            _listedItems.Add(ReadLine());
        }


        // This function outputs the number of items listed in an exercise.
        public void ListedItemsCount()
        {
            WriteLine($"\nYou listed {_listedItems.Count} items in this exercise.");
        }
    }
}