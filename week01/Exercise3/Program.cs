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
        //loop to determine if guess = number
        while (true)
        {
        //logic for guess = number
        int i = 0; 
        bool result = int.TryParse(guess, out i);

        //run if guess != number -- please ignore this. My roommate (Dalton) tries to break my code before I
        //submit it and this extra bit was just because I wanted to break-proof it as well as call him names
        //don't worry, he loved it.
        if (result == false)
        {
            //set dalton to neutral to count times dalton was dalton instead of help
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
            //break dalton loop if dalton = helpful
            if (result == true)
            {
                Console.WriteLine("Finally, you insufferable hag.");
                break;
            }
            Console.WriteLine("Try again:");
            guess = Console.ReadLine();
        }
        }

        //convert string guess to int guess
        int guessNumber = int.Parse(guess);

        //set times to start value
        times += 1;

        //break loop if guess right
        if (guessNumber == magicNumber)
        {
            break;
        }

        //continue loop if guess wrong + give user hint
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

        //display congratulations + # of guesses
        Console.WriteLine("Good Job! You got it!");
        Console.WriteLine($"It took you {times} tries.");
        
    }
}