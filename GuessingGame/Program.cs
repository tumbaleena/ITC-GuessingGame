using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            bool realInteger = false;
            Random random = new Random();
            int randomNumber = random.Next(21);
            int userNumberGuess = 0;

            Console.WriteLine("Hello! Welcome to the Guessing Game!");
            Console.Write("Please guess a number between 1 and 20: ");
            string userInput = Console.ReadLine();

            realInteger = int.TryParse(userInput, out userNumberGuess);

            if (userNumberGuess > 20 || userNumberGuess < 1 || realInteger == false)
            {
                Console.WriteLine("Sorry, the number needs to be a whole number between 1 and 20.");
            }

            if (userNumberGuess < randomNumber)
            {
                Console.WriteLine($"Guess Higher! (more than {userNumberGuess}");
            }
            else if (userNumberGuess > randomNumber)
            {
                Console.WriteLine($"Guess Lower (less than {userNumberGuess})");
            }
            else
            {
                Console.WriteLine($"You got it, Dude!  The correct number is {userNumberGuess}");
            }


            /*           userNumberGuess = int.Parse(userInput);
             *           if (userNumberGuess < randomNumber)
                       {
                           Console.WriteLine("Guess Higher");
                       }
                       else if (userNumberGuess == randomNumber)
                       {
                           Console.WriteLine("You got it, Dude!");
                       }
                       else
                       {
                           Console.WriteLine("Guess Lower");
                       }
            */
        }
    }
}
