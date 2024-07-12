using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGame
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Random random = new Random();
            bool playAgain = true;

            while (playAgain)
            {
                int randomNumber = random.Next(1, 11); // Random number between 1 and 10
                int attempts = 3;
                bool rightguess = false;

                Console.WriteLine("Guess the number from 1 to 10. You have 3 attempts.");

                for (int i = 1; i <=attempts; i++)
                {
                    Console.Write($"Attempt {i}: ");
                    int guessedNumber = int.Parse(Console.ReadLine());

                    if (guessedNumber == randomNumber)
                    {
                        Console.WriteLine($"Congratulations! You have guessed the number correctly in {i} attempts.");
                        rightguess = true;
                        break;
                    }
                    else if (guessedNumber > randomNumber)
                    {
                        Console.WriteLine("Too high!");
                    }
                    else
                    {
                        Console.WriteLine("Too low!");
                    }
                }

                if (!rightguess)
                    Console.WriteLine($"You have failed to guess the number in {attempts} attempts." +
                        $" The correct number was {randomNumber}.");

                Console.Write("Do you want to play again? (yes/no): ");
                string wantsPlayAgain = Console.ReadLine().ToLower();

                if (wantsPlayAgain != "yes")
                    playAgain = false;
            }

            Console.WriteLine("Thank you for playing!");


            /*
            Random random = new Random();
            int randomNumber = random.Next(1, 11); //generate random number from 1 to 10
            int attempts = 3;

            Console.WriteLine("Guess the number from 1 to 10. You have 3 attempts.");

            for (int i = 1; i <= attempts; i++)
            {
                Console.Write("Attempt "+i+" : Enter your guess: ");
                int userGuess = Convert.ToInt32(Console.ReadLine());

                if (userGuess == randomNumber)
                {
                    Console.WriteLine("Congratulations! You guessed the number correctly in "+i+" attempt(s).");
                    return;
                }
                else if (userGuess > randomNumber)
                    Console.WriteLine("Your guess is too high.");
                else
                {
                    Console.WriteLine("Your guess is too low.");
                }
            }

            Console.WriteLine("You have failed to guess the number "+attempts+" attempts exhausted.");
            Console.ReadLine();
            */
        }
    }
}
