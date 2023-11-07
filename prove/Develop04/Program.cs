using System;
using System.Formats.Asn1;
using System.Runtime.Intrinsics.X86;

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

        //BreathingActivity A2 = new BreathingActivity("Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
        //A2.Run();
        
        ReflectingActivity A3 = new ReflectingActivity("Reflecting Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
        A3.Run();

        //ListActivity A4 = new ListActivity("Listing Activity","This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
        //A4.Run();
    }
}