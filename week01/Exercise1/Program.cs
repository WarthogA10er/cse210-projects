using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        //store first name
        Console.WriteLine("What is your first name?");
        string first = Console.ReadLine();

        //store last name
        Console.WriteLine("What is your last name?");
        string last = Console.ReadLine();

        //display name
        Console.WriteLine($"Your name is {last}, {first} {last}.");
    }
}