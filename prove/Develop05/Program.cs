using System;

class Program
{
    static void Main(string[] args)
    {
        bool quit = false;
        
        GoalManager manager = new GoalManager();

        while (quit == false)
        {
            int menuInput = DisplayMenu();

            if (menuInput == 1)
            {
                Console.Clear();
                Console.WriteLine("What type of goal would you like to make? ");
                int newGoalType = NewGoalType();
                if (newGoalType == 1)
                {
                    SimpleGoal simple = new SimpleGoal();
                    simple.SetGoal();
                }
                else if (newGoalType == 2)
                {
                    EternalGoal eternal = new EternalGoal();
                    eternal.SetGoal();
                }
                else if (newGoalType == 3)
                {
                    ChecklistGoal checklist = new ChecklistGoal();
                    checklist.SetGoal();
                }
                Console.WriteLine();
            } 
            else if (menuInput == 2)
            {
                manager.DisplayGoals();
            }
            else if (menuInput == 3)
            {
                manager.SaveGoals();
            }
            else if (menuInput == 4)
            {

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
            Console.WriteLine("1) Create New Goal. ");
            Console.WriteLine("2) List Goals. ");
            Console.WriteLine("3) Save Goals. ");
            Console.WriteLine("4) Record Progress. ");
            Console.WriteLine("5) Quit. ");
            Console.WriteLine();

            Console.Write("Input number 1-5: ");
            int menuInput = int.Parse(Console.ReadLine());

            return menuInput;
        }
        static int NewGoalType()
        {
            Console.WriteLine();
            Console.WriteLine("1) Simple Goal. ");
            Console.WriteLine("2) Eternal Goal. ");
            Console.WriteLine("3) Checklist Goal. ");
            Console.WriteLine();

            Console.Write("Input number 1-3: ");
            int newGoalType = int.Parse(Console.ReadLine());

            return newGoalType;
        }
    }
}
