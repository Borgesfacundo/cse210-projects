using System;
using System.Formats.Asn1;
using System.Runtime.Intrinsics.X86;

class Program
{
    static void Main(string[] args)
    {
        string input;
        do
        {
            Console.WriteLine("Menu options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflecting activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Quit");

            input = Console.ReadLine();

            if (input == "1")
            {
                Console.Clear();
                BreathingActivity A1 = new BreathingActivity("Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
                A1.Run();
            }
            if (input == "2")
            {
                Console.Clear();
                ReflectingActivity A2 = new ReflectingActivity("Reflecting Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
                A2.Run();
            }
            if (input == "3")
            {
                Console.Clear();
                ListActivity A3 = new ListActivity("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
                A3.Run();
            }
            if ((input != "1") && (input != "2") && (input != "3") && (input != "4"))
            {
                Console.WriteLine("\nPlease enter a number between 1 to 4 \n");
            }
        }
        while (input != "4");




    }
}