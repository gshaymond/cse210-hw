using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string userInput = Console.ReadLine();
        int grade = int.Parse(userInput);

        if (grade < 60)
        {
            Console.WriteLine("You have an F!");
        }
        else if (grade < 68 && grade > 60 || grade == 60)
        {
            if (grade <= 63)
                Console.WriteLine("You have a D-!");
            if (grade >= 67)
                Console.WriteLine("You have a D+!");
            else
                Console.WriteLine("You have a D!");
        }
        else if (grade < 78 && grade > 70 || grade == 70)
        {
            if (grade <= 73)
                Console.WriteLine("You have a C-!");
            if (grade >= 77)
                Console.WriteLine("You have a C+!");
            else
                Console.WriteLine("You have a C!");
        }
        else if (grade < 88 && grade > 80 || grade == 80)
        {
            if (grade <= 83)
                Console.WriteLine("You have a B-!");
            if (grade >= 87)
                Console.WriteLine("You have a B+!");
            else
                Console.WriteLine("You have a B!");
        }
        else if (grade > 90 || grade == 90)
        {
            if (grade <= 93)
                Console.WriteLine("You have a A-!");
            if (grade >= 97)
                Console.WriteLine("You have a A+!");
            else
                Console.WriteLine("You have a A!");
        }
    }
}