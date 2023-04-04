using System;

public class Meal
{
    private string _mealName;
    private double _mealPrice;
    private string _mealDate;
    private string _meal;


    public virtual string SetMeal()
    {
        return _meal;
    }

    public void SetMealName(string mealName)
    {
        _mealName = mealName;
    }
    public string GetMealName()
    {
        return _mealName;
    }

    public void SetMealDate(string mealDate)
    {
        _mealDate = mealDate;
    }
    public DateTime GetMealDate()
    {
        return DateTime.Parse(_mealDate);
    }

    public void SetMealPrice(double mealPrice)
    {
        _mealPrice = mealPrice;
    }
    public double GetMealPrice()
    {
        return _mealPrice;
    }

     public virtual string ToFileString()
    {
        return " ";
    }

    public virtual void SetAllAttributes(string[] parts)
    {
        SetMealDate(parts[0]);
        SetMealName(parts[1]);
        SetMealPrice(double.Parse(parts[2]));
    }

    public double GetPrice()
    {
        return _mealPrice;
    }

    internal string[] Split(char v)
    {
        throw new NotImplementedException();
    }
}