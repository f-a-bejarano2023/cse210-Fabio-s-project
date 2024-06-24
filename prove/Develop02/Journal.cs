using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    private List<DailyEntry> entries = new List<DailyEntry>();

    // Add a new entry
    public void AddEntry(DailyEntry entry)
    {
        entries.Add(entry);
    }

    // Display all entries
    public void DisplayEntries()
    {
        foreach (var entry in entries)
        {
            entry.Display();
        }
    }

    // Save entries to a text file using '|' as delimiter
    public void SaveToFile(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        { 
            foreach (var entry in entries)
            {
                writer.WriteLine(entry.ToCsv());
            }
        }
    }

    // Load entries from a text file using '|' as delimiter
    public void LoadFromFile(string filename)
    {
        if (File.Exists(filename))
        {
            entries.Clear();
            var lines = File.ReadAllLines(filename);
            foreach (var line in lines)
            {
                entries.Add(DailyEntry.FromCsv(line));
            }
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }
}
