using System;

public class Goal
{
    private string _event;
    private string _goal;
    private int _goalPoints;
    private int _goalType;
    private string _goalName;
    private string _goalDescription;

    public virtual string RecordProgress()
    {
        return _event;
    }
    public virtual string SetGoal()
    {
        return _goal;
    }

    public void SetGoalName(string goalName)
    {
        _goalName = goalName;
    }
    public void SetGoalDescription(string goalDescription)
    {
        _goalDescription =  goalDescription;
    }
    public string GetGoalName()
    {
        return _goalName;
    }
    public string GetGoalDescription()
    {
        return _goalDescription;
    }

    public void SetGoalPoints(int goalPoints)
    {
        _goalPoints = goalPoints;
    }
    public int GetGoalPoints()
    {
        return _goalPoints;
    }

    public virtual string ToFileString()
    {
        return " ";
    }

    public virtual void SetAllAttributes(string[] parts)
    {
        SetGoalName(parts[0]);
        SetGoalDescription(parts[1]);
        SetGoalPoints(int.Parse(parts[2]));
    }
}