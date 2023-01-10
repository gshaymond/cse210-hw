using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        int number = 1;
        int sum = 0;
        int total = 0;
        int largest = 0;
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when you are finished.");

        while (number != 0)
        {
            Console.Write("Enter number: ");
            string numInput = Console.ReadLine();
            number = int.Parse(numInput);
            if (number == 0)
            {
                break;
            }
            else
            {
                numbers.Add(number);
                if (number > largest)
                {
                    largest = number;
                }
                sum += number;
                total = 1 + total;
            }
        }
        float avg = sum / total;
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {avg}");
        Console.WriteLine($"The largest number is: {largest}");
    }
}