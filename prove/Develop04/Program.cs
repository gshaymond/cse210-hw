using System;

class Program
{
    static void Main(string[] args)
    {
        bool quit = false;
        
        while (quit == false)
        {
            int menuInput = DisplayMenu();

            if (menuInput == 1)
            {
                Console.Clear();
                Reflection reflection = new Reflection();
                Console.WriteLine(reflection.GetName());
                Console.WriteLine(reflection.GetDescription());
                Console.WriteLine();
                reflection.DisplayRandPrompt();
                Console.WriteLine("Finsished");
            } 
            else if (menuInput == 2)
            {
                Console.Clear();
                Listing listing = new Listing();
                Console.WriteLine(listing.GetName());
                Console.WriteLine(listing.GetDescription());
                Console.WriteLine();
                listing.DisplayRandPrompt();
            }
            else if (menuInput == 3)
            {
                Console.Clear();
                Breathing breathing = new Breathing();
                Console.WriteLine(breathing.GetName());
                Console.WriteLine(breathing.GetDescription());
                Console.WriteLine();
                breathing.DisplayBreathe();
            }
            else if (menuInput > 4 || menuInput < 1)
            {
                Console.Clear();
                Console.WriteLine("Please choose 1-4.");
            }
            else
            {
                quit = true;
            }
        }   
    }
    static int DisplayMenu()
    {
        Console.WriteLine();
        Console.WriteLine("1) Reflecting Activity ");
        Console.WriteLine("2) Listing Activity ");
        Console.WriteLine("3) Breathing Activity ");
        Console.WriteLine("4) Quit ");
        Console.WriteLine();

        Console.Write("Input number 1-4: ");
        int menuInput = int.Parse(Console.ReadLine());

        return menuInput;
    }
}