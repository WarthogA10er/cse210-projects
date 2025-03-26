using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal1 = new Journal();
        while (true)
        {
            
            Console.WriteLine("Welcome to the Journal Program. Please make your selection:");
            Console.WriteLine("1. Add Entry");
            Console.WriteLine("2. Display Entries");
            Console.WriteLine("3. Save Entries");
            Console.WriteLine("4. Load Previous Entries");
            Console.WriteLine("5. Exit Program");
            Console.Write("Enter selection here > ");
            string menu = Console.ReadLine();
            if (menu == "1")
            {
                Entry newEntry = new Entry();
                journal1.AddEntry(newEntry);
                // journal1._entries.Add(newEntry);   
            }
            else if (menu == "2")
            {
                Console.WriteLine($"In menu display entry()");
                journal1.DisplayAll();
            }
            else if (menu == "3")
            {
                Console.WriteLine("Please enter a file name.");
                Console.Write("> ");
                string fileName = Console.ReadLine();
                journal1.SaveToFile(fileName);
            }
            else if (menu == "4")
            {
                Console.WriteLine("Please enter a file name.");
                Console.Write("> ");
                string fileName = Console.ReadLine();
                journal1.LoadFromFile(fileName);
            }
            else if (menu == "5")
            {
                break;
            }
        }
        Console.WriteLine("Thank you. Have a great day.");
    }
}

