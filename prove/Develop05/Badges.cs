using System;
using static System.Console;

namespace EternalQuest
{
    class Badges
    {
        //Private attribute to store badge level
        private string _badgeLevel;

        //Constructor for Badges class
        public Badges()
        {
            _badgeLevel = "00";
        }


        //Method to set each Badge Level
        public string GetBadgeLevel(int points)
        {
            if (points <= 200)
            {
                _badgeLevel = "00";
            }

            else if (points <= 400)
            {
                _badgeLevel = "01";
            }

            else if (points <= 800)
            {
                _badgeLevel = "02";
            }

            else if (points <= 1400)
            {
                _badgeLevel = "03";
            }
            
            else if (points <= 2200)
            {
                _badgeLevel = "04";
            }

            else if (points <= 3200)
            {
                _badgeLevel = "05";
            }

            else if (points <= 4400)
            {
                _badgeLevel = "06";
            }

            else if (points <= 5800)
            {
                _badgeLevel = "07";
            }

            else if (points <= 7400)
            {
                _badgeLevel = "08";
            }

            else if (points <= 9200)
            {
                _badgeLevel = "09";
            }

            else if (points <= 11200)
            {
                _badgeLevel = "10";
            }
            return _badgeLevel;
        }


        //Method to display the badgeArt
        public string BadgeArt(string _badgeLevel)
        {

        string badgeArt = @$"         ,   /\   ,
        / '-'  '-' \
       | GoalMaster |
       \    .--.    /
       |   ( {_badgeLevel} )   |
        \   '--'   /
         '--.  .--'
             \/";
            
            return badgeArt;
        }
    }
}