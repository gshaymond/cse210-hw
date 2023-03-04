using System;

public class Breathing : Activity
{
    private string _name;
    private string _description;

    public string GetDescription()
    {
        return _description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }
    public void DisplayBreathe()
    {
        Console.Write("How many seconds would you like to breath? ");
        int seconds = int.Parse(Console.ReadLine());
        Console.WriteLine();

        while (seconds > 0 )
        {
            
            Console.WriteLine("Breath in...");
            DisplayCountdown(5);
            seconds = seconds - 5;
        
            Console.WriteLine("Breath out...");
            DisplayCountdown(5);
            Console.WriteLine();
            seconds = seconds - 5;
            
        }

        Console.WriteLine("Well done.");
        
    }
    public string GetName()
    {
        return _name = "Breathing Activity";
    }
}