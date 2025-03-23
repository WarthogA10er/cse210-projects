using System;

List<string> fruits = new List<string>
{
    "Apple", "Banana", "Cherry", "Dragonfruit", "Elderberry"
};

// Random object
Random rnd = new Random();

// Get random index
int index = rnd.Next(fruits.Count);

// Print random fruit
Console.WriteLine(fruits[index]);