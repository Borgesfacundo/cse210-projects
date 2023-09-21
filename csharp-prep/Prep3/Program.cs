using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.Write("What is the magic number? ");
        Random randomGenerator = new Random();
        int mNumber = randomGenerator.Next(1, 100);

        int guess = 0;
        int tries = 0;

        while (guess != mNumber)
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            tries += 1; 

            if (guess < mNumber)
            {
                Console.WriteLine("Higher! ");
            }
            else if (guess > mNumber)
            {
                Console.WriteLine("Lower ");
            }
            else 
            {
                Console.WriteLine("You Guessed it!");
                Console.WriteLine($"You took {tries} tries! ");
            }
        }
    }
}