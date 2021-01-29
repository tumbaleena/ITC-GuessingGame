using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            bool realInteger;
            Random random = new Random();
            int randomNumber = random.Next(1, 21);
            int userNumberGuess = 0;
            int guessCount = 0;

            string userRange;
            int lowerLimit;
            int upperLimit;

            Console.WriteLine("Hello! Welcome to the Guessing Game!");
            Console.Write("Enter the lowest number possible: ");
            userRange = Console.ReadLine();
            lowerLimit = int.Parse(userRange);

            Console.Write("Enter the highest number possible: ");
            userRange = Console.ReadLine();
            upperLimit = int.Parse(userRange);

            randomNumber = random.Next(lowerLimit, (upperLimit + 1));

        Restart:
         //  Console.Write("Please guess a number between 1 and 20: ");
            Console.Write("Please guess a number: ");
            string userInput = Console.ReadLine();

            // this is our 'true or false' check.  it tries to parse the string into an integer, and if it can, it will output the userInput to the variable 'userNumberGuess'
            realInteger = int.TryParse(userInput, out userNumberGuess);

            if (realInteger == false || userNumberGuess > upperLimit || userNumberGuess < lowerLimit)
            {
                Console.WriteLine($"Sorry, the number needs to be a whole number between {lowerLimit} and {upperLimit}.");
            }

            if (userNumberGuess < randomNumber)
            {
                Console.Write($"Guess Higher! (more than {userNumberGuess}) - ");
                guessCount = guessCount + 1;
                goto Restart;
            }
            else if (userNumberGuess > randomNumber)
            {
                Console.Write($"Guess Lower (less than {userNumberGuess}) - ");
                guessCount = guessCount + 1;
                goto Restart;
            }
            else
            {
                Console.WriteLine($"You got it, Dude!  The correct number is {userNumberGuess}");
                guessCount = guessCount + 1;
                Console.WriteLine($"It took you {guessCount} tries to guess this random number.");
            }
        }
    }
}
