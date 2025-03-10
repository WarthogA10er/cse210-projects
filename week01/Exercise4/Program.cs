using System;
using System.Transactions;

class Program
{
    static void Main(string[] args)
    {
        List <float> list = new List<float>();

        Console.WriteLine("Welcome! Please enter your list of numbers one at a time.");
        Console.WriteLine("When you are finished entering all your numbers, type 0 to exit the program");

        while(true)
        {
            Console.WriteLine("Enter a number:");
            string numberString = Console.ReadLine();
            
            float number = float.Parse(numberString);
            
            if (number == 0)
            {
                break;
            }

            list.Add(number);
        }

        float min = list.AsQueryable().Min();
        float max = list.AsQueryable().Max();
        float sum = list.Sum();
        float average = list.Average();

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The smallest number us: {min}");
        Console.WriteLine($"The largest number is: {max}");
        Console.WriteLine($"The average is: {average}");

    }
}