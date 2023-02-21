using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment a1 = new Assignment("Samual Bennet", "Multiplication");
        Console.WriteLine();
        Console.WriteLine(a1.GetSummary());
        Console.WriteLine();
        
        Math a2 = new Math("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        Console.WriteLine();
        Console.WriteLine(a2.GetSummary());
        Console.WriteLine(a2.GetHomeworkList());
        Console.WriteLine();

        Writing a3 = new Writing("Mary Waters", "European History", "The Causes of World War II by Mary Waters");
        Console.WriteLine();
        Console.WriteLine(a3.GetSummary());
        Console.WriteLine(a3.GetWritingInfo());
        Console.WriteLine();
    }
}