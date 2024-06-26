using System;

class Program
{
    static void Main(string[] args)
    {
        bool playAgain = true;
        
        while (playAgain)
        {
            Random randomGenerator = new Random();
            int secretNumber = randomGenerator.Next(1, 101);
            int guessNumber = 0;

            Console.WriteLine("Guess the secret number between 1 and 100:");

            while (guessNumber != secretNumber)
            {
                Console.Write("What is your guess? ");
                guessNumber = int.Parse(Console.ReadLine());

                if (guessNumber < secretNumber)
                {
                    Console.WriteLine("Higher");
                }
                else if (guessNumber > secretNumber)
                {
                    Console.WriteLine("Lower");
                }
            }

            Console.WriteLine("Now, You´ve done it!!!");

            Console.Write("Do you want to play again? (yes/no): ");
            playAgain = Console.ReadLine().ToLower() == "yes";
        }

        Console.WriteLine("Thank you for playing!!!");
    }
}