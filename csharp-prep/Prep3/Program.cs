using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int chosen = randomGenerator.Next(1, 2000000);
        Console.WriteLine("A number has been chosen.");
            
        // do
        // {
        //     Console.Write("Make your guess from 1 to 2,000,000. ");
        //     guess 

        // } while (guess != chosen);
        

    }
}