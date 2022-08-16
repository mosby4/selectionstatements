using System;

namespace selectionstatement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Welcome to the number guessing game!");
            Console.WriteLine($"Test your luck and guess the right number.");
            Console.WriteLine($"What is the upper limit for the range of the number");

            var userResponse = Console.ReadLine();
            var uppperLimit = int.Parse(userResponse);

            var random = new Random();
            var number = random.Next(1, uppperLimit);

            Console.WriteLine($"What is your guess?");

            var guess = int.Parse(Console.ReadLine());

            if(guess > number)
            {
                Console.WriteLine($"Sorry that is not correct. guess is to high.");

            }

            else(guess == number)
            {
                Console.WriteLine($"Winner Winner chicken dinner!");
            }

            if (guess < number)
            {
                Console.WriteLine($"Sorry, guess is to low");
            }
        }
    }
}

