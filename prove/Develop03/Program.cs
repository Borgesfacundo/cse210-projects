using System;

class Program
{
    static void Main(string[] args)
    {
        //Scripture string
        
        
        //Displays References with only one verse
        Reference Reference = new("John", "3", "16");

        //Create a Scripture Object
        Scripture Scripture = new(Reference, "God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.");


        //Display references with more than one verse
        //Reference R2 = new("Jose", "5", "2", "5");
        //R2.GetDisplayReference();
        
        //Checking Word class
        //Word W1 = new("Juan");
        //W1.Hide();
        //Console.WriteLine(W1.Show());

        //Word W2 = new("Pablo");
        //W2.Show();
        //Console.WriteLine(W2.Show());
        
        
    }
}