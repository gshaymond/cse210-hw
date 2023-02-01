using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();


        bool quit = false;

        while (quit == false)
        {
            int menuInput = DisplayMenu();

            if (menuInput == 1)
            {
                Entry entry = new Entry();
                string prompt = entry.PromptGenerator();
                Console.WriteLine(prompt);
                string journalEntry = Console.ReadLine();
                entry.GetDate();
                entry.input = journalEntry;
                journal.entries.Add(entry);
            } 
            else if (menuInput == 2)
            {
                journal.DisplayJournal();
            }
            else if (menuInput == 3)
            {
                journal.ReadJournal();
            }
            else if (menuInput == 4)
            {
                journal.WriteJournal();
            }
            else
            {
                quit = true;
            }
        }

    }

    static int DisplayMenu()
    {
        Console.WriteLine("1) Write in Journal. ");
        Console.WriteLine("2) Display Journal. ");
        Console.WriteLine("3) Load Journal. ");
        Console.WriteLine("4) Save Journal. ");
        Console.WriteLine("5) Quit. ");

        Console.Write("Input number 1-5: ");
        int menuInput = int.Parse(Console.ReadLine());

        return menuInput;
    }
}