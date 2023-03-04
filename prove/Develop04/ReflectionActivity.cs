using System;

public class Reflection : Activity
{
    private string _name;
    private string _description;

    private List<string> _usedPrompts = new List<string>();

    List<string> _prompts = new List<string>(){
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };
    List<string> _questions = new List<string>(){
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?", 
        "What made this time different than other times when you were not as successful?", 
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };
    public string GetDescription()
    {
        return _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
    }
    public void DisplayRandPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        string _prompt = _prompts[index];

        Console.WriteLine($"---{_prompt}---");
        Console.WriteLine();
        DisplayCountdown(10);
        Console.WriteLine();
        DisplayQuestion();
    }
    int breaker = 0;
    public void DisplayQuestion()
    {
        for (int i = 0; i <= 8; ++i)
        {
            Random random = new Random();
            int index = random.Next(_questions.Count);
            string _question = _questions[index];

            if (breaker != 8)
            {
                ++breaker;
                CompareUsedPrompt();
            }
            else
            {
                break;
            }
        }
    }

    public void CompareUsedPrompt()
    {
        foreach (string _question in _questions)
        {
            if (_usedPrompts.Contains(_question))
            {   
                DisplayQuestion();
            }
            else
            {
                Console.WriteLine(_question);
                Console.WriteLine();
                DisplayCountdown(3);
                _usedPrompts.Add(_question);
            }
        }
    }
    public string GetName()
    {
        return _name = "Reflection Activity";
    }
}