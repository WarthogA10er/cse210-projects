using System.IO;

public class Journal
    {
        
        public List<Entry> _entries = new List<Entry>();


        public void AddEntry(Entry newEntry)
        {
            newEntry._date = DateTime.Today.ToString();

            PromptGenerator promptGen = new PromptGenerator();
            List<string> list = promptGen._prompts;
            string prompt = promptGen.GetRandomPrompt(list);
            newEntry._promptText = prompt;
            Console.WriteLine(prompt);

            Console.Write("Write your journal entry here > ");
            newEntry._entryText = Console.ReadLine();

            _entries.Add(newEntry);
            Console.WriteLine(_entries.Count);
        }
        public void DisplayAll()
        {
            Console.WriteLine($"In journal display all()");
            Console.WriteLine(_entries.Count);
            foreach (Entry entry in _entries)
            {
                Console.WriteLine($"In journal display all() in loop");
                entry.Display();
            }
        }
        public void SaveToFile(string fileName)
        {
           using (StreamWriter outputFile = new StreamWriter(fileName))
            {
                    outputFile.WriteLine(_entries);
            }
        }
        public void LoadFromFile(string fileName)
        {
           List<Entry> lines = System.IO.File.ReadAllLines(fileName);
           foreach (Entry line in lines)
           {
                line.Display();
           }
        }
    }

