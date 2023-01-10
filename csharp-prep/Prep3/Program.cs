using System;

class Program
{
    
    
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int chosen = randomGenerator.Next(1, 2000000);
        Console.WriteLine("A number has been chosen.");
        int guess = 0;


        while (guess != chosen)
        {
            Console.Write("Make your guess from 1 to 2,000,000. ");
            string userInput = Console.ReadLine();
            guess = int.Parse(userInput);
            if (guess > chosen)
            {
                Console.WriteLine("Guess Lower.");
            }
            else if (guess < chosen)
            {
                Console.WriteLine("Guess Higher.");
            }
            else
            {
                Console.WriteLine($"Correct, the number is {chosen}");
            }
        }

    }
}