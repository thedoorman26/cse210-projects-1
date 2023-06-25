using System;
using System.IO;
using System.Collections.Generic;
using static System.Console;


namespace Foundation1
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("\nYouTube Video Tracking!");
            WriteLine("Press any key to see video data...");
            ReadKey();


            //First Video Data Entry
            Video video1 = new Video("BYU Idaho Campus Tour", "BeSmartCES", 139);
            video1.AddComment("Mylee Montag", "I'm checking out BYU Provo this fall for general conference, but I'm still not sure if I should go to BYU I or BYU!!! I love the big feeling of BYU, but I love the larger spiritual aspect of BYU I");
            video1.AddComment("Rich Aphuel", "I am blessed to get accepted at this University. It is my honor to be the part of the university. I am ready and excited for life changing experience. In some corner, I am proud of my hard work for acceptance. Thank you BYUI!");
            video1.AddComment("Ingle Fe", "This is the year, I'm going to BYU Idaho. I'm so grateful for this opportunity. This Church is amazing.");
            video1.AddComment("Justin Barnes", "I attended here and earned 30 credits from 2017 until 2019.");


            //Second Video Data Entry
            Video video2 = new Video("Overview of Brigham Young University", "BYU Admissions", 217);
            video2.AddComment("Martin Alianelli", "One of the most beautiful campuses!");
            video2.AddComment("Thomas Hutson", "I have been wanting to go to BYU since I was 7. I am in the 8th grade now and I am working really hard to get into BYU.");
            video2.AddComment("Becca Marie", "The best school ever!");
            video2.AddComment("Kelsey Wammack", "I went there BYU Campus this is Beautiful place I really love to go.");


            //Third Video Data Entry
            Video video3 = new Video("BYU–Hawaii Campus Tour", "BYU-Hawaii", 269);
            video3.AddComment("Jeferson Dey", "Amazing video, I can´t wait to get BYUH the next Spring 2021.");
            video3.AddComment("Jedric Valdemoro", "I can't wait to get to BYUH. I am now applying to get there.");
            video3.AddComment("Sheena Papa", "What a beautiful place....I saw my flag. Aloha from Papua New Guinean.");
            video3.AddComment("Chloe Haymond", "I just got accepted for fall 2021!!! so excited");


            //Fourth Video Data Entry
            Video video4 = new Video("Virtual 3D BYU Campus Created by Engineering Students", "Brigham Young University", 198);
            video4.AddComment("Dave Lindsey", "Very cool.  Thank you to the whole team for all the hard work.  Now we can all appreciate our beautiful campus from anywhere in the world!  Wow!");
            video4.AddComment("Donal Pearce", "Much appreciation for such a fine project! Well done");
            video4.AddComment("Shawn Cordner", "Just wish you could have done this back in 82 when I graduated. I miss the Widsow building and the Cluff  green houses.");
            video4.AddComment("Steven Doyel", "Welcome to BYU-VR.");

            List<Video> _videos = new List<Video> {video1, video2};

            foreach (Video v in _videos)
            {
                v.DisplayVideo();
                
                WriteLine("\nComments:");
                foreach (Comment c in v._comments)
                {
                    c.DisplayComments();
                }

                Write("\nPress any key to see next video...\n\n");
                ReadKey();
            }
            
            WriteLine("\nEnd of Video Data Listed!  Thanks for checking vidoe tracking!");

        }
    }
}
