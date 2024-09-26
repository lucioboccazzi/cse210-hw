using System;
using System.Collections.Generic;
using System.IO;

public class Journal 
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(string promptText, string entryText)
    {
        Entry entry = new Entry(promptText, entryText);
        _entries.Add(entry);
    }

    public void DisplayAll()
    {
        foreach (var entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (var entry in _entries)
            {
                writer.WriteLine($"{entry._date}|{entry._promptText}|{entry._entryText}");
            }
        }
        Console.WriteLine("Entries saved.");
    }

    public void LoadFromFile(string filename)
    {
        if (File.Exists(filename))
        {
            _entries.Clear();
            foreach (var line in File.ReadAllLines(filename))
            {
                var parts = line.Split('|');
                if (parts.Length == 3)
                {
                    Entry entry = new Entry(parts[1], parts[2]) { _date = parts[0] };
                    _entries.Add(entry);
                }
            }
            Console.WriteLine("Entries loaded.");
        }
        else
        {
            Console.WriteLine("No saved entries found.");
        }
    }
}
