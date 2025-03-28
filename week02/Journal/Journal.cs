// AI Example Journal.cs
using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    public List<Entry> _entries;

    public Journal()
    {
        _entries = new List<Entry>();
    }

    public void AddEntry(string prompt, string response)
    {
        Entry newEntry = new Entry();
        newEntry._date = DateTime.Now.ToString();
        newEntry._prompt = prompt;
        newEntry._response = response;
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("No entries found.");
        }

        foreach (Entry entry in _entries)
        {
            string displayEntry = entry.Display();
            Console.WriteLine(displayEntry);
        }
    }

    public void SaveToFile(string filename)
    {
            using (StreamWriter writer = new StreamWriter(filename))
            {
                foreach (Entry entry in _entries)
                {
                    writer.WriteLine($"{entry._date}|{entry._prompt}|{entry._response}");
                }
            }
    }

    public void LoadFromFile(string filename)
    {
        using (StreamReader reader = new StreamReader(filename))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] parts = line.Split('|');
                if (parts.Length == 3)
                {
                    _entries.Add(new Entry(parts[1], parts[2], parts[0]));
                }
            }
        }
    }
}