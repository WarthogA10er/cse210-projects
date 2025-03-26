// public class Entry
//     {
//         public string _date;
//         public string _promptText;
//         public string _entryText;

//         public void Display()
//         {
//            Console.WriteLine($"Date: {_date}. Prompt: {_promptText}. Journal Entry: {_entryText}");
//         }
//     }

// AI Example
using System;

public class Entry
{
    public string Prompt { get; set; }
    public string Response { get; set; }
    public string Date { get; set; }

    public Entry(string prompt, string response, string date)
    {
        Prompt = prompt;
        Response = response;
        Date = date;
    }

    public override string ToString()
    {
        return $"Date: {Date}\nPrompt: {Prompt}\nResponse: {Response}\n";
    }
}
