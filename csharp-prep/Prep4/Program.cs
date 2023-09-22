using System;

class Program
{
    static void Main(string[] args)
    {

        List<int> numbers = new();

        int userNumber = -1;

        while (userNumber != 0)
        {
            Console.Write("Enter a list of numbers, type 0 when finished. ");
            string userAnswer = Console.ReadLine();
            userNumber = int.Parse(userAnswer);

            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        }

        int sum = 0;

        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"The sum is {sum}");

        float avg = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is {avg}");

        int max = numbers[0];

        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }
    
    Console.WriteLine($"The max is {max}");

    }
}