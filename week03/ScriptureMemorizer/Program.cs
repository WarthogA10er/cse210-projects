using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");
        Console.WriteLine("Please enter a scripture reference:");
        string reference = Console.ReadLine();
        if(reference.Contains("-"))
        {
            Console.WriteLine("How many verses are in this scripture?");
            string stringVerses = Console.ReadLine();
            int numberVerse = int.Parse(stringVerses);
        }
    }
}

// SCRIPTURE Store a scripture, including both the reference (for example "John 3:16") and the text of the scripture.
// SCRIPTURE Accommodate scriptures with multiple verses, such as "Proverbs 3:5-6".
// SCRIPTURE Clear the console screen and display the complete scripture, including the reference and the text.
// PROGRAM Prompt the user to press the enter key or type quit.
// PROGRAM If the user types quit, the program should end.
// SCRIPTURE If the user presses the enter key (without typing quit), the program should hide a few random words in the scripture, clear the console screen, and display the scripture again. (Hiding a word means that the word should be replace by underscores (_) and the number of underscores should match the number of letters in that word.)
// PROGRAM The program should continue prompting the user and hiding more words until all words in the scripture are hidden.
// PROGRAM When all words in the scripture are hidden, the program should end. (The final display of the scripture should show the scripture with all words hidden.)
// SCRIPTURE WORD? When selecting the random words to hide, for the core requirements, you can select any word at random, even if the word was already hidden. (As a stretch challenge, try to randomly select from only those words that are not already hidden.)
// SCRIPTURE Provide multiple constructors for the scripture reference to handle the case of a single verse and a verse range ("Proverbs 3:5" or "Proverbs 3:5-6").