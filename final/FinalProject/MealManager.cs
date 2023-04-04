using System;
using System.IO;
using System.Collections.Generic;

class MealManager
{
    MealDate date = new MealDate();
    List<Meal> _mealList = new List<Meal>();

    public MealManager()
    {
        LoadMeals();
        date.CheckDates(_mealList);
        
    }

    public void AddMeal(Meal meal)
    {
        _mealList.Add(meal);
    }

    public void RemoveMeal(int meal)
    {
        string path = @"Meals.txt";

        File.WriteAllText(path, string.Empty);
        _mealList.RemoveAt(meal - 1);
        SaveMeals();
    }

    public void SaveMeals()
    {
        string path = @"Meals.txt";

        File.WriteAllText(path, string.Empty);

        using (StreamWriter outputFile = new StreamWriter("Meals.txt"))
        {
            foreach (Meal meal in _mealList)
            {
                outputFile.WriteLine(meal.ToFileString());
            }
        }
    }
    public void ListMeals()
    {
        int count = 1;
        foreach (Meal meal in _mealList)
        {
            Console.WriteLine($"{count}) {meal.ToString()}");
            ++count;
        }
        Console.WriteLine();
        MealPrice price = new MealPrice();
        double total = price.CalcTotalCost();
        double average = price.CalcAverageCost();
        Console.WriteLine($"Total cost of meals: ${total}");
        Console.WriteLine($"Average cost of meals: ${average}");
        Console.WriteLine();
    }
    public void LoadMeals()
    {
        string[] lines = System.IO.File.ReadAllLines("Meals.txt");

        foreach (string line in lines)
        {
            Meal newMeal;
            string[] parts = line.Split('|');
            string meal = DetermineMeal(parts);

            if (meal == "Breakfast")
            {
                newMeal = new Breakfast();
            }
            else if (meal == "Lunch")
            {
                newMeal = new Lunch(); 
            }
            else
            {
                newMeal = new Dinner();
            }
            
            newMeal.SetAllAttributes(parts);
            AddMeal(newMeal);
        }
    }
    
    public string DetermineMeal(string[] parts)
    {
        if (parts.Count() == 3)
        {
            return "Breakfast";
        }
        else if (parts.Count() == 4)
        {
            return "Lunch";
        }
        else
        {
            return "Dinner";
        }
    }

    public List<Meal> GetMeals()
    {
        return _mealList;
    }
}