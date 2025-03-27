// using System.IO;

// public class Journal
//     {
        
//         public List<Entry> _entries = new List<Entry>();


//         public void AddEntry(Entry newEntry)
//         {
//             newEntry._date = DateTime.Today.ToString();

//             PromptGenerator promptGen = new PromptGenerator();
//             List<string> list = promptGen._prompts;
//             string prompt = promptGen.GetRandomPrompt(list);
//             newEntry._promptText = prompt;
//             Console.WriteLine(prompt);

//             Console.Write("Write your journal entry here > ");
//             newEntry._entryText = Console.ReadLine();

//             _entries.Add(newEntry);
//             Console.WriteLine(_entries.Count);
//         }
//         public void DisplayAll()
//         {
//             Console.WriteLine($"In journal display all()");
//             Console.WriteLine(_entries.Count);
//             foreach (Entry entry in _entries)
//             {
//                 Console.WriteLine($"In journal display all() in loop");
//                 entry.Display();
//             }
//         }
//         public void SaveToFile(string fileName)
//         {
//            using (StreamWriter outputFile = new StreamWriter(fileName))
//             {
//                     outputFile.WriteLine(_entries);
//             }
//         }
//         public void LoadFromFile(string fileName)
//         {
//            List<Entry> lines = System.IO.File.ReadAllLines(fileName);
//            foreach (Entry line in lines)
//            {
//                 line.Display();
//            }
//         }
//     }

// AI Example
using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    public List<Entry> Entries { get; private set; }

    public Journal()
    {
        Entries = new List<Entry>();
    }

    public void AddEntry(string prompt, string response)
    {
        string date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        Entries.Add(new Entry(prompt, response, date));
    }

    public void DisplayEntries()
    {
        if (Entries.Count == 0)
        {
            Console.WriteLine("No entries found.");
            return;
        }

        foreach (var entry in Entries)
        {
            Console.WriteLine(entry);
        }
    }

    public void SaveToFile(string filename)
    {
        try
        {
            using (StreamWriter writer = new StreamWriter(filename))
            {
                foreach (var entry in Entries)
                {
                    writer.WriteLine($"{entry.Date}|{entry.Prompt}|{entry.Response}");
                }
            }
            Console.WriteLine("Journal saved successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error saving journal: " + ex.Message);
        }
    }

    public void LoadFromFile(string filename)
    {
        try
        {
            Entries.Clear();
            using (StreamReader reader = new StreamReader(filename))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split('|');
                    if (parts.Length == 3)
                    {
                        Entries.Add(new Entry(parts[1], parts[2], parts[0]));
                    }
                }
            }
            Console.WriteLine("Journal loaded successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error loading journal: " + ex.Message);
        }
    }
}
