using System;
using System.Formats.Asn1;

class Program
{
    static void Main(string[] args)
    {
        //Activity A1 = new Activity("breathing Activity", "This activity will help you to breath in and breath out", "Thank yoy for taking the time to breath");
       // Console.WriteLine(A1.GetStartingMessage());
       // int duration= A1.SetTime();
       // A1.CountDownTimer(duration);
        //A1.ShowSpinner(20);
        //A1.EndMessage();

        BreathingActivity A2 = new BreathingActivity("Breathing Activity", "This is a nice breathing activity");
        Console.WriteLine(A2.GetStartingMessage());
        A2.EndMessage();
        
    }
}