using System;

class Program
{
    static void Main(string[] args)
    {
        bool quit = false;

        MealManager manager = new MealManager();

        while (quit == false)
        {
            int menuInput = DisplayMenu();

            if (menuInput == 1)
            {
                Console.Clear();
                Console.WriteLine("What type of meal would you like to plan? ");
                int newMealType = NewMealType();
                if (newMealType == 1)
                {
                    Breakfast breakfast = new Breakfast();
                    breakfast.SetMeal();
                    manager.AddMeal(breakfast);
                }
                else if (newMealType == 2)
                {
                    Lunch lunch = new Lunch();
                    lunch.SetMeal();
                    manager.AddMeal(lunch);
                }
                else if (newMealType == 3)
                {
                    Dinner dinner = new Dinner();
                    dinner.SetMeal();
                    manager.AddMeal(dinner);
                }
                Console.WriteLine();
            }
            else if (menuInput == 2)
            {
                Console.Clear();
                manager.ListMeals();
                Console.WriteLine();
            }
            else if (menuInput == 3)
            {
                Console.Clear();
                manager.SaveMeals();
                Console.WriteLine("All meals are saved.");
            }
            else if (menuInput == 4)
            {
                Console.Clear();
                manager.ListMeals();
                Console.WriteLine();
                Console.Write("Which meal would you like to remove? (Choose by number) ");
                int removedMeal = int.Parse(Console.ReadLine());
                manager.RemoveMeal(removedMeal);
            }
            else if (menuInput > 5 || menuInput < 1)
            {
                Console.Clear();
                Console.WriteLine("Please choose 1-5.");
            }
            else
            {
                quit = true;
            }
        }

        static int DisplayMenu()
        {
            Console.WriteLine();
            Console.WriteLine("1) Create New Meal Plan. ");
            Console.WriteLine("2) List Planned Meals. ");
            Console.WriteLine("3) Save Meals. ");
            Console.WriteLine("4) Remove A Meal. ");
            Console.WriteLine("5) Quit. ");
            Console.WriteLine();

            Console.Write("Input number 1-5: ");
            int menuInput = int.Parse(Console.ReadLine());

            return menuInput;
        }

        static int NewMealType()
        {
            Console.WriteLine();
            Console.WriteLine("1) Breakfast. ");
            Console.WriteLine("2) Lunch. ");
            Console.WriteLine("3) Dinner. ");
            Console.WriteLine();

            Console.Write("Input number 1-3: ");
            int newMealType = int.Parse(Console.ReadLine());

            return newMealType;
        }
    }
}