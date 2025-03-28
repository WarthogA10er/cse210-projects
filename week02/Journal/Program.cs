// AI Example Program.cs
using System;
using System.Linq;

public class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();

        while (true)
        {
          //  Console.Clear();
            Console.WriteLine("Welcome to the Journal Program");
            Console.WriteLine("1. Add an Entry");
            Console.WriteLine("2. Display Entries");
            Console.WriteLine("3. Save Journal");
            Console.WriteLine("4. Load Journal");
            Console.WriteLine("5. Exit");
            Console.Write("Choose an option: ");
            string menu = Console.ReadLine();

            
                if(menu == "1")
                    {
                        PromptGenerator promptGenerator = new PromptGenerator();
                        List<string> prompts = promptGenerator._prompts;
                        string prompt = promptGenerator.GetRandomPrompt(prompts);

                        Console.WriteLine(prompt);
                        Console.Write(">");
                        string response = Console.ReadLine();

                        journal.AddEntry(prompt, response);
                    }
                else if (menu == "2")
                    {
                        journal.DisplayAll();
                    }
                else if (menu == "3")
                    {
                        Console.Write("Enter filename: ");
                        string filename = Console.ReadLine();
                        journal.SaveToFile(filename);
                    }
                else if (menu == "4")
                    {
                        Console.Write("Enter filename: ");
                        string filename = Console.ReadLine();
                        journal.LoadFromFile(filename);
                    }
                else if (menu == "5")
                    break;
        }
    }
}


