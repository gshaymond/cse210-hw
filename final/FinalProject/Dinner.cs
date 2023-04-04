using System;

class Dinner : Meal
{
    public override string SetMeal()
    {
        Console.Write("What is the name of this Meal? ");
        string mealName = Console.ReadLine();
        Console.Write("What date will you eat this Meal? (Jan 1, 2000) ");
        string mealDate = Console.ReadLine();
        Console.Write("How much will this meal cost? $");
        double mealPrice = double.Parse(Console.ReadLine());

        SetMealName(mealName);
        SetMealDate(mealDate);
        SetMealPrice(mealPrice);

        return base.SetMeal();
    }

    public override string ToString()
    {
        return $"{GetMealDate()}: {GetMealName()}, (${GetMealPrice()})";
    }

    public override string ToFileString()
    {
        return $"{GetMealDate()}|{GetMealName()}|{GetMealPrice()}| |";
    }
}