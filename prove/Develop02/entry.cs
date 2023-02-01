using System;


public class Entry
{
    public string input;
    public string prompt;
    public string dateText;
    
    public string PromptGenerator()
    {
        Random random = new Random();

        List<string> promptList = new List<string>();
        promptList.Add("What was the highlight of today?");
        promptList.Add("Who did you spend most of today with?");
        promptList.Add("What was the most interseting thing you did today?");
        promptList.Add("What would you have done differently today?");
        promptList.Add("How are you feeling right now?");
        
        int randInt = random.Next(0, promptList.Count());
        string randPrompt = promptList[randInt];
        prompt = randPrompt;

        return randPrompt;
    }
    public void GetDate()
    {
        DateTime theDate = DateTime.Now;
        dateText = theDate.ToShortDateString();
    }
    public void DisplayEntry()
    {
        Console.WriteLine($"{dateText}: {prompt}\n\t{input}");
    }
}