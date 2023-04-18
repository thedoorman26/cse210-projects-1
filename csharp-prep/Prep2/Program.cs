using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string userValue = Console.ReadLine();
        int gradePercent = int.Parse(userValue);
        string letter = "";

        if (gradePercent >= 90)
        {
            letter = "A";
        }
        else if (gradePercent >= 80)
        {
            letter = "B";
        }
        else if (gradePercent >= 70)
        {
            letter = "C";
        }
        else if (gradePercent >= 60)
        {
            letter = "D";
        }
        else 
        {
            letter = "F";
        }
        
        int signCalculation = gradePercent % 10;
        string sign = "";

        if (signCalculation >= 7)
        {
            sign = "+";
        }
        else if (signCalculation >= 3)
        {
            sign = " ";
        }
        else if (signCalculation < 3)
        {
            sign = "-";
        }

        string gradeConversion = letter + sign;
        string grade = "";

        if (gradeConversion == "A+")
        {
            grade = "A";
        }
        else if (gradeConversion == "F-")
        {
            grade = "F";
        }
        else if (gradeConversion == "F+")
        {
            grade = "F";
        }
        else
        {
            grade = gradeConversion;
        }

        Console.WriteLine($"The grade you earned is: {grade}");

        if (gradePercent >= 70)
        {
            Console.WriteLine("Congratulations! You have passed the class. ");
        }
        else
        {
            Console.WriteLine("You have not passed the class.  Please try again. Never stop trying!");
        }
    }
}