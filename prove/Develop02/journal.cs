using System.IO;

public class Journal
{
    public List<Entry> entries = new List<Entry>();
    private string[] _lines;

    public void writeJournal()
    {
        Console.WriteLine("What would you like your file to be called? ");
        string fileName = Console.ReadLine();

        StreamWriter outputFile = new StreamWriter(fileName);

        using(outputFile)
        {
            if (_lines != null)
            {
                foreach (string line in _lines)
                {
                    outputFile.WriteLine(line);
                }
            }

            foreach(Entry entry in entries)
            {
                outputFile.WriteLine($"{entry.dateText}: {entry.prompt}\n\t{entry.input}");
            }
        }
    }
    public void readJournal()
    {
        Console.WriteLine("Which file would you like to see? ");
        string fileName = Console.ReadLine();
        _lines = System.IO.File.ReadAllLines(fileName);  
    }
    public void displayJournal()
    {
        if (_lines != null)
        {
            foreach (string line in _lines)
            {
                Console.WriteLine(line);
            }
        }

        foreach(Entry entry in entries)
        {
            entry.displayEntry();
        }
    }
}