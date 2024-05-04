using System;
using System.Collections.Generic;
using System.IO;


public class Journal
{
    public List<Entry> _entryText = new List<Entry> ();

    public void AddEntry()
    {

    }

    public void DisplayAll()
    {
        string filename = "entry.txt";

        string [] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            Console.WriteLine(line);
        } 

    }

    public void SaveToFile()
    {
        string filename = "entry.txt";

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry p in _entryText)
            {
                outputFile.WriteLine($"{p._entryText}");
            }
        }
        
    }

    public void LoadFromFile()
    {
        
    }
}