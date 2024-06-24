using System;

public class DailyEntry
{
    public string Date { get; set; }
    public string Prompt { get; set; }
    public string Response { get; set; }

    // Display entry
    public void Display()
    {
        Console.WriteLine($"Date: {Date}");
        Console.WriteLine($"Prompt: {Prompt}");
        Console.WriteLine($"Response: {Response}");
        Console.WriteLine();
    }

    // Convert entry to CSV format using '|' as delimiter
    public string ToCsv()
    {
        return $"{Date}|{Prompt}|{Response}";
    }

    // Create entry from CSV format using '|' as delimiter
    public static DailyEntry FromCsv(string csvLine)
    {
        var parts = csvLine.Split('|');
        return new DailyEntry
        {
            Date = parts[0],
            Prompt = parts[1],
            Response = parts[2]
        };
    }
}
