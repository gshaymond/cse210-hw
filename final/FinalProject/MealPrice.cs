using System;

class MealPrice
{
    MealManager manager = new MealManager();
    public double CalcAverageCost()
    {
        int mealCount = manager.GetMeals().Count();
        double total = CalcTotalCost();
        double average = total / mealCount;

        return average;
    }
    public double CalcTotalCost()
    {
        double total = 0.0;
        
        foreach (Meal meal in manager.GetMeals())
        {
            total = total + meal.GetPrice();
        }
        return total;
    }
}