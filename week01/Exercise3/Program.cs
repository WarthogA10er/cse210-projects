using System;
using System.Data;

class Program
{
    static void Main(string[] args)
    {
        //choose random number
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);
        int dalton = 0;

        //start game
        Console.WriteLine("I have picked a number between 1 and 100. Try to guess it:");
        string guess = Console.ReadLine();

        //set val to count times run
        int times = 1;

        //start loop
        while (true)
        {
        //logic to determine if guess = number
        while (true)
        {
        int i = 0; 
        bool result = int.TryParse(guess, out i);

        if (result == false)
        {
            dalton += 1;
            Console.WriteLine("Stop it Dalton.");
            Thread.Sleep(1500);
            if (dalton >=2)
            {
                Console.WriteLine("You suck.");
                Thread.Sleep(1500);
            }

            if (dalton >=4)
            {
                Console.WriteLine("I hate you.");
                Thread.Sleep(1500);
            }

            if (dalton >=6)
            {
                Console.WriteLine("Stop it Douche.");
                Thread.Sleep(1500);
            }

            if (dalton >=9)
            {
                Console.WriteLine("This is why you're single.");
                Thread.Sleep(5000);
                Console.WriteLine("Sorry, that may have been too harsh");
                Thread.Sleep(2000);
                Console.WriteLine("Nevermind. You deserved it.");
            }

            if (result == true)
            {
                Console.WriteLine("Finally, you insufferable hag.");
                break;
            }
            Console.WriteLine("Try again:");
            guess = Console.ReadLine();
        }
        }

        int guessNumber = int.Parse(guess);

        times += 1;

        if (guessNumber == magicNumber)
        {
            break;
        }

        if (guessNumber != magicNumber)
        {
            if (guessNumber > magicNumber)
            {
                Console.WriteLine("Not quite. Try to guess a little lower.");
                Console.WriteLine("Guess again:");
                guess = Console.ReadLine();
            }

            if (guessNumber < magicNumber)
            {
                Console.WriteLine("Not quite. Try to guess a little higher.");
                Console.WriteLine("Guess again:");
                guess = Console.ReadLine();               
            }

        }
        }
        Console.WriteLine("Good Job! You got it!");
        Console.WriteLine($"It took you {times} tries.");
        
    }
}