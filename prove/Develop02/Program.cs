using System;

class Program
{
    private static Journal journal = new Journal();
    private static string[] prompts = new[]
    {
        "Who was the most meaningful experience I want to remember of today?",
        "Did I learn anything new today that I want to remember?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
         "Did I hear Him today? if not, what can I do better tomorow to hear Him?",
        "If I was allowed to improve or change one thing of today, what would it be?"
    };
    private static Random random = new Random();

    public static void Main()
    {
        bool running = true;
        while (running)
        {
            Console.WriteLine("Journal Menu");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Exit");
            Console.Write("Select an option: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    WriteNewEntry();
                    break;
                case "2":
                    journal.DisplayEntries();
                    break;
                case "3":
                    SaveJournal();
                    break;
                case "4":
                    LoadJournal();
                    break;
                case "5":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }

    private static void WriteNewEntry()
    {
        string prompt = prompts[random.Next(prompts.Length)];
        Console.WriteLine($"Prompt: {prompt}");
        Console.Write("Your response: ");
        string response = Console.ReadLine();

        var entry = new DailyEntry
        {
            Date = DateTime.Now.ToString("yyyy-MM-dd"),
            Prompt = prompt,
            Response = response
        };

        journal.AddEntry(entry);
    }

    private static void SaveJournal()
    {
        Console.Write("Enter filename to save (e.g.,  C:/Users/Soraya/Desktop/Fabio-s-Pathway/cse210/cse210-Fabio-s-project/Fabio-s-Journal.txt): ");
        string filename = Console.ReadLine();
        journal.SaveToFile(filename);
        Console.WriteLine("Journal saved.");
    }

    private static void LoadJournal()
    {
        Console.Write("Enter filename to load (e.g.,  C:/Users/Soraya/Desktop/Fabio-s-Pathway/cse210/cse210-Fabio-s-project/Fabio-s-Journal.txt): ");
        string filename = Console.ReadLine();
        journal.LoadFromFile(filename);
        Console.WriteLine("Journal loaded.");
    }
}