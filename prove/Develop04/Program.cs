using System;

class Program
{
    static void Main(string[] args)
    {
        Activity A1 = new Activity("brathing Activity", "This activity will help you to breath in and breath out", "Thank yoy for taking the time to breath");
        Console.WriteLine(A1.GetStartingMessage());
        A1.SetTime();
        A1.EndMessage();
        
    }
}