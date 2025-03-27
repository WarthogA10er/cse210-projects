// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         Journal journal1 = new Journal();
//         while (true)
//         {
            
//             Console.WriteLine("Welcome to the Journal Program. Please make your selection:");
//             Console.WriteLine("1. Add Entry");
//             Console.WriteLine("2. Display Entries");
//             Console.WriteLine("3. Save Entries");
//             Console.WriteLine("4. Load Previous Entries");
//             Console.WriteLine("5. Exit Program");
//             Console.Write("Enter selection here > ");
//             string menu = Console.ReadLine();
//             if (menu == "1")
//             {
//                 Entry newEntry = new Entry();
//                 journal1.AddEntry(newEntry);
//                 // journal1._entries.Add(newEntry);   
//             }
//             else if (menu == "2")
//             {
//                 Console.WriteLine($"In menu display entry()");
//                 journal1.DisplayAll();
//             }
//             else if (menu == "3")
//             {
//                 Console.WriteLine("Please enter a file name.");
//                 Console.Write("> ");
//                 string fileName = Console.ReadLine();
//                 journal1.SaveToFile(fileName);
//             }
//             else if (menu == "4")
//             {
//                 Console.WriteLine("Please enter a file name.");
//                 Console.Write("> ");
//                 string fileName = Console.ReadLine();
//                 journal1.LoadFromFile(fileName);
//             }
//             else if (menu == "5")
//             {
//                 break;
//             }
//         }
//         Console.WriteLine("Thank you. Have a great day.");
//     }
// }

// AI Example
using System;
using System.Linq;

public class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        string[] prompts = {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?"
        };

        while (true)
        {
            Console.Clear();
            Console.WriteLine("Journal Program");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Exit");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    {
                        Random random = new Random();
                        int promptIndex = random.Next(prompts.Length);
                        string selectedPrompt = prompts[promptIndex];

                        Console.WriteLine($"Prompt: {selectedPrompt}");
                        Console.Write("Your response: ");
                        string response = Console.ReadLine();

                        journal.AddEntry(selectedPrompt, response);
                        Console.WriteLine("Entry added successfully!");
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                        break;
                    }
                case "2":
                    journal.DisplayEntries();
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                    break;
                case "3":
                    {
                        Console.Write("Enter filename to save journal: ");
                        string filename = Console.ReadLine();
                        journal.SaveToFile(filename);
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                        break;
                    }
                case "4":
                    {
                        Console.Write("Enter filename to load journal: ");
                        string filename = Console.ReadLine();
                        journal.LoadFromFile(filename);
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                        break;
                    }
                case "5":
                    return;
                default:
                    Console.WriteLine("Invalid option. Try again.");
                    break;
            }
        }
    }
}
