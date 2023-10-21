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
        Console.WriteLine(Scripture.GetRenderedText());

        //While the user press enter the program will hide 3 words
        while {
            
        }
        
    }
}