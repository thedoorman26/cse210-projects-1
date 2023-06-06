using System;
using static System.Console;

namespace Mindfulness
{
    class ListingActivity : Activity
    {
        private List<string> _listingPrompt;

        private List<string> _listedItems;


        public ListingActivity(string activity, string description, int time): base(activity, description, time)
        {
            _listingPrompt = new List<string>();
            _listedItems = new List<string>();
        }

        public void CreateListingPrompts()
        {
            _listingPrompt.Add(new string("Who are people that you appreciate?"));
            _listingPrompt.Add(new string("What are personal strengths of yours?"));
            _listingPrompt.Add(new string("Who are people that you have helped this week?"));
            _listingPrompt.Add(new string("When have you felt the Holy Ghost this month?"));
            _listingPrompt.Add(new string("Who are some of your personal heroes?"));
        }

        public void DisplayListingPrompt()
        {
            CreateListingPrompts();
            WriteLine(_listingPrompt[GetRandomPromptIndex(_listingPrompt.Count)]);
            WriteLine("\n");
        }

        public void RunListing(DateTime endTime)
        {
            DisplayActivityStart();

            DisplayListingPrompt();

            while (DateTime.Now < endTime)
            {            
                KeepListing();
            }

            ListedItemsCount();
            DisplayActivityClose();
        }
        public void KeepListing()
        {
            Write("List Item: ");
            _listedItems.Add(ReadLine());
        }

        public void ListedItemsCount()
        {
            WriteLine($"You listed {_listedItems.Count} items in this exercise.");
        }
    }


}