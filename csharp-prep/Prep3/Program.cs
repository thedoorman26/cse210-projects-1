using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Guess a number between 1 and 20.");
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 21);
       
        int guess = -1;
        int numOfGuesses = 0;

        while (guess != number)
        {
            Console.Write("What is your guess? ");
            string userGuess = Console.ReadLine();
            guess = int.Parse(userGuess);
            numOfGuesses += 1;

        
            if (guess > number)
            {
                Console.WriteLine("Lower");
            }    
            else if (guess < number)
            {
                Console.WriteLine("Higher");
            }
            else if (guess == number)
            {
                Console.WriteLine("You guessed it?");
                Console.WriteLine($"It took {numOfGuesses} guesses to get the right answer.");
            }
            
        }




    }
}