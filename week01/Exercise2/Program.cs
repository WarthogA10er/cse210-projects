using System;

class Program
{
    static void Main(string[] args)
    {
        //store grade percent
        Console.WriteLine("What is your Grade Percentage?:");
        string percent = Console.ReadLine();
        
        //convert str to int
        int percentNumber = int.Parse(percent);

        //set letter to neutral
        string letter = "";
        //logic to find grade
        if (percentNumber >= 90)
        {
            letter = "A";
        }

        else if (percentNumber >= 80)
        {
            letter = "B";
        }

        else if (percentNumber >= 70)
        {
            letter = "C";
        }

        else if (percentNumber >= 60)
        {
            letter = "D";
        }

        else if (percentNumber < 60)
        {
           letter = "F";
        }

        //set sign to neutral
        string sign = "";
        
        //logic to exclude extreme grades
        if (percentNumber < 96 && percentNumber >59)
        {
            //logic for + or -
            int remainder = percentNumber % 10;
            if (remainder >= 7)
            {
                sign = "+";
            }

            else if (remainder < 3)
            {
                sign = "-";
            }
        }
        
        //logic for pass or fail
        if (percentNumber >= 70)
        {
            Console.WriteLine("Good job, you passed!");
        }

        else if (percentNumber < 70)
        {
            Console.WriteLine("You'll get it next time.");
        }

        //display grade
        Console.WriteLine($"Your grade is {letter}{sign}.");
        
    }
}