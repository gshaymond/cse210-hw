using System;

public class Activity
{
    private string _description = "";
    private string _name = "";

    public void DisplayWelcome(string description, string name)
    {
        _description = description;
        _name = name;
    }

    public void DisplayCountdown(int time)
    {
        for (int i = time; i >= 0 + 1; i--)
        {
            if (i > 9)
            {
                Console.Write("\b\b \b");
            }
            else
            {
                Console.Write("\b \b\b");
            }
            Console.Write($"{i}");
            Thread.Sleep(1000);
        }
        Console.Write("\b \b");
    }
}