using System;

public class SimpleGoal : Goal
{
    private bool _complete;

    public override string RecordProgress()
    {
        return base.RecordProgress();
    }
    public override string SetGoal()
    {
        Console.Write("What is the name of the Goal? ");
        string goalName = Console.ReadLine();
        Console.Write("\nWhat is the description of the Goal? ");
        string goalDescription = Console.ReadLine();
        Console.Write("\nHow many points will you receive for completing this Goal? ");
        int goalPoints = int.Parse(Console.ReadLine());
        
        SetGoalName(goalName);
        SetGoalDescription(goalDescription);
        SetGoalPoints(goalPoints);

        return base.SetGoal();
    }

    public override string ToString()
    {
        return $"[ ] {GetGoalName()}: {GetGoalDescription()}, {GetGoalPoints()}";
    }

    public override string ToFileString()
    {
        return $"{GetGoalName()}|{GetGoalDescription()}|{GetGoalPoints()}| ";
    }
}