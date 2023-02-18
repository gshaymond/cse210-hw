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
                Scripture scripture = new Scripture();
                string script = scripture.Display();
                Console.WriteLine(script);
            } 
            else if (menuInput == 2)
            {
                Console.Clear();
                Scripture scripture = new Scripture();
                scripture.SplitText();
            }
            else if (menuInput > 3 || menuInput < 1)
            {
                Console.Clear();
                Console.WriteLine("Please input a 1, 2, or 3.");
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
        Console.WriteLine("1) Display Scripture. ");
        Console.WriteLine("2) Hide words. ");
        Console.WriteLine("3) Quit.");
        Console.WriteLine();


        Console.Write("Input number 1-3: ");
        int menuInput = int.Parse(Console.ReadLine());

        return menuInput;
    }
}