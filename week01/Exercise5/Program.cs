using System;

class Program
{
    static void Main(string[] args)
    {
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
        }

        static string PromptUserName()
        {
            Console.WriteLine("Please enter your name:");
            string userName = Console.ReadLine();
            return userName;
        }

        static int PromptUserNumber()
        {
            Console.WriteLine("Please enter your favorite number:");
            string fav = Console.ReadLine();
            int favNumber = int.Parse(fav);
            return favNumber;
        }

        static int SquareNumber(int favNumber)
        {
            int numberSquare = favNumber * favNumber;
            return numberSquare;
        }

        static void DisplayResult(string userName, int numberSquare)
        {
            Console.WriteLine($"{userName}, your number squared is {numberSquare}.");
        }

        DisplayWelcome();

        string userName = PromptUserName();
        int favNumber = PromptUserNumber();

        int squaredNumber = SquareNumber(favNumber);

        DisplayResult(userName, squaredNumber);
    }
}