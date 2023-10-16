using System;

class Program
{
    static void Main(string[] args)
    {
        //Displays References with only one verse
        Reference R1 = new("Juan", "5", "22");
        R1.GetDisplayReference();

        //Display references with more than one verse
        Reference R2 = new("Jose", "5", "2", "5");
        R2.GetDisplayReference();
        
        
        
    }
}