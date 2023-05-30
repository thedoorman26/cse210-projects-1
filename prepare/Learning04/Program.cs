using System;
using static System.Console;

namespace Homework
{
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning04 World!");

        Assignment homework1 = new Assignment("Lenora Stevens", "Inheritance");

        WriteLine(homework1.GetSummary());

        MathAssignment mathHomework = new MathAssignment("Alex Stevens", "Fractions", "Section 7.3", "8-19");
        WriteLine(mathHomework.GetSummary());
        WriteLine(mathHomework.GetHomeworkList());

        WritingAssignment writeHomework = new WritingAssignment("Ethan Stevens", "European History", "The Causes of World Ward II by Mary Waters");
        WriteLine(writeHomework.GetSummary());
        WriteLine(writeHomework.GetWritingInformation());
    }
}
}