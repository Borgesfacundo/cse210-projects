using System;

class Program
{
    static void Main(string[] args)
    {        
        //Displays References with only one verse
        Reference Reference = new("John", "3", "16");

        //Create a Scripture Object
        Scripture Scripture = new(Reference, "God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.");

        //While the user press enter the program will hide 3 words
        string input = "";
        do{
            Console.Clear();
            Console.WriteLine(Scripture.GetRenderedText());

            Console.WriteLine("Press enter to continue or type 'quit' to finish:");
            input = Console.ReadLine();
            //call HideWords to chose 3 random words to hide
            Scripture.HideWords();
            if (Scripture.AllHidden() == true)
            {
                //display all hidden and finish it
                Console.Clear();
                Console.WriteLine(Scripture.GetRenderedText());
                break;
            }
        }
        while (input != "quit");
    }
}