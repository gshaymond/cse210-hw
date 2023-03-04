using System;

public class Listing : Activity
{
    private string _name;
    private string _description;
    private int _responses;
    private int _counter;

    private DateTime startTime;
    private DateTime futureTime;
    private DateTime currrentTime;

    List<string> _prompts = new List<string>(){
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };
    public void DisplayRandPrompt()
    {
        Console.Write("How many seconds would you like to take for listing? ");
        int seconds = int.Parse(Console.ReadLine());
        Console.WriteLine();

        Random random = new Random();
        int index = random.Next(_prompts.Count);
        string _prompt = _prompts[index];
        
        Console.WriteLine($"---{_prompt}---");
        Console.WriteLine();
        Console.WriteLine($"You may begin in...");
        DisplayCountdown(5);
        
        startTime = DateTime.Now;
        futureTime = startTime.AddSeconds(seconds);
        DateTime currentTime = DateTime.Now;
        
        
        while(currentTime < futureTime)
        {
            Console.Write("> ");
            Console.ReadLine();
            ++_responses;
            currentTime = DateTime.Now;
        }
        
        Console.WriteLine();
        Console.WriteLine("Finished.");
        Console.WriteLine($"You gave {_responses} responses.");
    }

    public string GetName()
    {
        return _name = "Listing Activity";
    }

    public string GetDescription()
    {
        return _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    }
}