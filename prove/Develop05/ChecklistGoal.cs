using System;

public class ChecklistGoal : Goal
{
    private int _completionCount;
    private int _currentCount;
    private int _progressPoints;


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
        Console.Write("\nHow many times will it take to complete this Goal? ");
        _completionCount = int.Parse(Console.ReadLine());
        Console.Write("\nHow many point will you receive for you progress? ");
        _progressPoints = int.Parse(Console.ReadLine());
        Console.Write("\nHow many points will you receive for completing this Goal? ");
        int goalPoints = int.Parse(Console.ReadLine());

        SetGoalName(goalName);
        SetGoalDescription(goalDescription);
        SetGoalPoints(goalPoints);

        return base.SetGoal();
    }

    public override string ToString()
    {
        return $"[{_currentCount}/{_completionCount}] {GetGoalName()}: {GetGoalDescription()}, {GetGoalPoints()}, {_progressPoints}";
    }

    public override string ToFileString()
    {
        return $"{_currentCount}|{_completionCount}|{GetGoalName()}|{GetGoalDescription()}|{GetGoalPoints()}|{_progressPoints}";
    }

    public override void SetAllAttributes(string[] parts)
    {
        _currentCount = int.Parse(parts[0]);
        _completionCount = int.Parse(parts[1]);
        SetGoalName(parts[2]);
        SetGoalDescription(parts[3]);
        SetGoalPoints(int.Parse(parts[4]));
        _progressPoints = int.Parse(parts[5]);
    }
}