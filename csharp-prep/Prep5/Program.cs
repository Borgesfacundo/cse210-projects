using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
    
        string userName = PromptUserName();

        int userNumber = PromptUserNumber();

        int squareNumber = SquareNumber(userNumber);

        DisplayResult(userName, squareNumber);

    }
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }
    static string PromptUserName()
    {
        Console.Write("Enter your username ");
        string userName = Console.ReadLine();
        return userName;
    }
    static int PromptUserNumber()
    {
        Console.Write("Enter your favorite number ");
        string number = Console.ReadLine();
        int favNumber = int.Parse(number);
        return favNumber;
    }
    static int SquareNumber(int number)
    {
        int squareNumber = number * number;
        return squareNumber;
    }
    static void DisplayResult(string userName, int squareNumber)
    {
        Console.WriteLine($"Welcome {userName}");
        Console.WriteLine($"The square number is {squareNumber}");
    }
}