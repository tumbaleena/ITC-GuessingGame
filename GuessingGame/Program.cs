using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            bool realInteger = false;
            Random random = new Random();
            int randomNumber = random.Next(1, 21);
            int userNumberGuess = 0;

            Console.WriteLine("Hello! Welcome to the Guessing Game!");
            Console.Write("Please guess a number between 1 and 20: ");
            string userInput = Console.ReadLine();

            // this is our 'true or false' check.  it tries to parse the string into an integer, and if it can, it will output the userInput to the variable 'userNumberGuess'
            realInteger = int.TryParse(userInput, out userNumberGuess);

            if (realInteger == false || userNumberGuess > 20 || userNumberGuess < 1)
            {
                Console.WriteLine($"Sorry, the number needs to be a whole number between 1 and 20.");
            }

            if (userNumberGuess < randomNumber)
            {
                Console.WriteLine($"Guess Higher! (more than {userNumberGuess})");
            }
            else if (userNumberGuess > randomNumber)
            {
                Console.WriteLine($"Guess Lower (less than {userNumberGuess})");
            }
            else
            {
                Console.WriteLine($"You got it, Dude!  The correct number is {userNumberGuess}");
            }
        }
    }
}
