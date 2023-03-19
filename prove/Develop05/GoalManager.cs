using System;
using System.IO;
using System.Collections.Generic;

class GoalManager
{
    List<Goal> _goalList = new List<Goal>();

    public GoalManager()
    {
        LoadGoals();
    }
    
    public void AddGoal(Goal goal)
    {
        _goalList.Add(goal);
    }
    public void DisplayGoals()
    {
        foreach (Goal goal in _goalList)
        {
            Console.WriteLine(goal.ToString());
        }
    }
    public void SaveGoals()
    {
        using (StreamWriter outputFile = new StreamWriter("Goals.txt"))
        {
            string path = @"Goals.txt";
 
            File.WriteAllText(path, string.Empty);

            foreach (Goal goal in _goalList)
            {
                outputFile.WriteLine(goal.ToFileString());
            }
        }
    }
    public void LoadGoals()
    {
        string[] lines = System.IO.File.ReadAllLines("Goals.txt");

        foreach (string line in lines)
        {
            Goal newGoal;
            string[] parts = line.Split('|');
            string goal = DetermineGoal(parts);

            if (goal == "Checklist")
            {
                newGoal = new ChecklistGoal();
            }
            else if (goal == "Simple")
            {
                newGoal = new SimpleGoal(); 
            }
            else
            {
                newGoal = new EternalGoal();
            }
            
            newGoal.SetAllAttributes(parts);
            AddGoal(newGoal);
        }
    }

    public string DetermineGoal(string[] parts)
    {
        if (parts.Count() == 6)
        {
            return "Checklist";
        }
        else if (parts.Count() == 4)
        {
            return "Simple";
        }
        else
        {
            return "Eternal";
        }
    }
}