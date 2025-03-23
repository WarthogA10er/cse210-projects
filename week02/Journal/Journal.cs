using System.IO.Enumeration;

public class Journal
    {
        
        public List<Entry> _entries;

        public void AddEntry()
        {
            
        }
        public void DisplayAll()
        {
           // Console.WriteLine($"{_givenName} {_familyName}");
        }
        public void SaveToFile()
        {
           Console.Write("Please enter the file name: ");
            string fileName = Console.ReadLine();
        }
        public void LoadFromFile()
        {
           Console.Write("Please enter the file name: ");
            string fileName = Console.ReadLine();
        }
    }
