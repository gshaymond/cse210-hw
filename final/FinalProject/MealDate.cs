using System;
using System.IO;
using System.Collections.Generic;

class MealDate
{
    public void CheckDates(List<Meal> _mealList)
    {
        DateTime currentDate = DateTime.Today;
        
        foreach (Meal meal in _mealList)
        {
            string[] parts = meal.Split('|');
            DateTime mealDate = DateTime.Parse(parts[0]);
            int result = DateTime.Compare(mealDate, currentDate);
            if (result < 0)
                Console.WriteLine($"The date for {meal} has passed.");
        }
        
    }
}