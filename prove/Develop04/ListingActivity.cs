using System;
using static System.Console;

namespace Mindfulness
{
    class ListingActivity : Activity
    {
        private List<string> _listingPrompt;

        private List<string> _listedItems;

        public ListingActivity()
        {

        }
        public ListingActivity(string activity, string description): base(activity, description)
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
            _listingPrompt.Add(new string("What miracles have you seen in your life?"));
        }

        public void DisplayListingPrompt()
        {
            CreateListingPrompts();
            WriteLine(_listingPrompt[GetRandomPromptIndex(_listingPrompt.Count)]);
            WriteLine("\nPress any key to begin...\n");
            ReadKey();
        }

        public void RunListing()
        {
            _activityTime = RequestActivityDuration();
            DisplayListingPrompt();
            
            DateTime endTime = SetTimeDuration();
            PauseTime("Start thinking");

            while (DateTime.Now < endTime)
            {            
                KeepListing();
            }

            ListedItemsCount();
                       
        }
        public void KeepListing()
        {
            WriteLine("");
            Write("List Item: ");
            _listedItems.Add(ReadLine());
        }

        public void ListedItemsCount()
        {
            WriteLine($"\nYou listed {_listedItems.Count} items in this exercise.");
        }
    }


}