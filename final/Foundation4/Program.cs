using System;

class Program
{
    static void Main(string[] args)
    {
        Running running = new Running(20, "23 Sep 2023", 85);
        Console.WriteLine(running.GetSummary());

        Cycling cycling = new Cycling(35, "25 Jul 2022",120);
        Console.WriteLine(cycling.GetSummary());

        Swimming swimming = new Swimming(10, "14 Feb 2021", 25);
        Console.WriteLine(swimming.GetSummary());
    }
}