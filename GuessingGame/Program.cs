using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            bool realInteger = false;
            int randomNumber;
            int userNumberGuess = 0;

            Console.WriteLine("Hello! Welcome to the Guessing Game!");
            Console.Write("Please guess a number between 1 and 20: ");
            string userInput = Console.ReadLine();

            realInteger = int.TryParse(userInput, out userNumberGuess);
    		//userNumberGuess = int.Parse(userInput);
        }
    }
}
