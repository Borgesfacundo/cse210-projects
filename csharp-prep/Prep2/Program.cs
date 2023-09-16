using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string gradePercentage = Console.ReadLine();

        int grade = int.Parse(gradePercentage);

        string letter = "";

        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80 && grade < 90) 
        {
            letter = "B";

        }
        else if (grade >= 70 && grade < 80) 
        {
            letter = "C";

        }
        else if (grade >= 60 && grade < 70) 
        {
            letter = "D";

        }
        else if (grade < 60)
        {
            letter = "F";

        }
        Console.WriteLine($"Your grade is: {letter}");
            if (grade >= 70)
            {
                Console.WriteLine("Congratulations, you passed the course!");
            }
            else 
            {
                Console.WriteLine("Sorry, but you didn't pass the course!");
                Console.WriteLine("You will do it better next time");


            }
    }
}