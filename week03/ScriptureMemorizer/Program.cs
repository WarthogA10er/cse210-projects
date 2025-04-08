using System;
using System.Data;

class Program
{
    static void Main(string[] args)
    {
        Scripture scripture = new Scripture();
        Reference reference = new Reference();
        
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");
        Console.WriteLine("Please enter a scripture reference:");
        string input = Console.ReadLine();

        reference.SetReference(input);
        int verses = reference.ReturnNumberVerses();

        if(verses > 1)
        {
            Console.WriteLine("Please enter each verse individually.");
        }

        for(int i = 0; i < verses; i++)
        {
            Console.WriteLine("Enter verse:");
            string verse = Console.ReadLine();
            scripture.AddVerse(verse);
        }

        while(true)
        {
            scripture.DisplayScripture(reference);
            
            string enter;
            Console.WriteLine("Press enter to continue or type 'quit' to end the program:");
            enter = Console.ReadLine();

            if(enter.ToLower() == "quit")
            {
                break;
            }
            int remainder = scripture.CompareScripToHidden();
            if(remainder == 0)
            {
                break;
            }
            for(int i = 0; i < 3; i++)
            {
                if(remainder != 0)
                {
                scripture.HideRandomWord();
                }
            }
        }
        Console.WriteLine("Have a good day!");
    }
}

