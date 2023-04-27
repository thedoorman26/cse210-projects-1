using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        List<int> numbers = new List<int>();
        int number = 0;
        string userNumber = "";
        int sum = 0;
        int maxNum = 0;
        float ave = 0;
        int smallestPosNum = 99999;

        while (userNumber != "0")
        {
            Console.Write("Enter number: ");
            userNumber = Console.ReadLine();
            number = int.Parse(userNumber);
            numbers.Add(number);

            // Compute the sum, or total, of the numbers in the list.
            sum += number;

            // Find the maximum, or largest, number in the list.
            
            foreach (int integer in numbers)
            {
                if(number > maxNum)
                {
                    maxNum = number;   
                }
                if(number > 0 && number < smallestPosNum)
                {
                    smallestPosNum = number;
                }
            }
        }
        // Compute the average of the numbers in the list.
            ave = ((float)sum) / ((numbers.Count) -1);

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {ave}");
        Console.WriteLine($"The largest number is: {maxNum}");
        Console.WriteLine($"The smallest positive number is: {smallestPosNum}");
        Console.WriteLine("The sorted list is: ");

        numbers.Sort();
        for (int i = 0; i < numbers.Count; i++)
        {
            int sortedNum = numbers[i];
            Console.WriteLine(sortedNum);
        }
            

    }
}