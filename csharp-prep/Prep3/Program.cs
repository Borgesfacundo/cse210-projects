using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.Write("What is the magic number? ");
        Random RandomGenerator = new Random();
        int mNumber = RandomGenerator.Next(1, 100);

        int guess = 0;

        while (guess != mNumber)
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (guess < mNumber)
            {
                Console.WriteLine("Lower! ");
            }
            else if (guess > mNumber)
            {
                Console.WriteLine("higher ");
            }
            else 
            {
                Console.WriteLine("You Guessed it!");
            }
        }
    }
}