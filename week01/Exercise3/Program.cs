using System;
using System.Data;

class Program
{
    static void Main(string[] args)
    {
        //choose random number
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);

        //start game
        Console.WriteLine("I have picked a number between 1 and 100. Try to guess it:");
        string guess = Console.ReadLine();

        //set val to count times run
        int times = 0;

        //start loop
        while (true)
        {

        //loop to determine if guess = number
        while (true)
        {
        //logic for guess = number
        int i = 0; 
        bool result = int.TryParse(guess, out i);

        //run if guess != number
        if (result == false)
        {
            Console.WriteLine("Sorry, that is not a valid guess.");
            Console.WriteLine("Try again:");
            guess = Console.ReadLine();
            
        }

        //break loop when guess = valid
        if (result == true)
        {
            break;
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