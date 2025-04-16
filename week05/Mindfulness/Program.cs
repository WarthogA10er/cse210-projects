using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Mindfulness Project.");
        while(true)
        {
            //Console.Clear();  
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Start Breathing Activity");
            Console.WriteLine("2. Start Listing Activity");
            Console.WriteLine("3. Start Reflecting Activity");
            Console.WriteLine("4. Display Log");
            Console.WriteLine("5. Quit");
            string menu = Console.ReadLine();
            int menuInt = int.Parse(menu);

        
            if(menuInt == 1)
            {
                Breathing breathing = new Breathing();
                breathing.Run();
            }

            else if(menuInt == 2)
            {
                Listing listing = new Listing();
                listing.Run();
            }

            else if(menuInt == 3)
            {
                Reflecting reflecting = new Reflecting();
                reflecting.Run();
            }

            else if(menuInt == 4)
            {
                Dictionary<string, int> activitesLog = new Dictionary<string, int>(){{"Breathing Activity", 0}, {"Listing Activity", 0}, {"Reflecting Activity", 0} };
                // int breathingTotal = 0;
                // int listingTotal = 0;
                // int reflectingTotal = 0;

                using (StreamReader reader = new StreamReader("Log.txt"))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] parts = line.Split(':');
                        string key = parts[0];
                        int value = int.Parse(parts[1]);

                        activitesLog[key] += value;
                    }

                    Console.WriteLine($"Breathing Activity Total Time: {activitesLog["Breathing Activity"]}");
                    Console.WriteLine($"Listing Activity Total Time: {activitesLog["Listing Activity"]}");
                    Console.WriteLine($"Reflecting Activity Total Time: {activitesLog["Reflecting Activity"]}");

                    Thread.Sleep(1500);
                }
            }
            else if(menuInt == 5)
            {
                break;
            }
        }
        Console.WriteLine("Have a great day!");
    }
}