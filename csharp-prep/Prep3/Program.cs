using System;

class Program
{
    static void Main(string[] args)
    {
        int guessCount = 0;

        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);

        while (guessCount != magicNumber)
        {
            Console.WriteLine("What is your guess?");
            int guess = int.Parse(Console.ReadLine());
            guessCount++;

            if (guess > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else if (guess < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine($"You guessed it right! You guessed in {guessCount} times.");
                
                
            }
        }
    }
}