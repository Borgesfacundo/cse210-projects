using System;

class Program
{
    static void Main(string[] args)
    {
    string useranswer = "0";
    
    while (useranswer != "5")
    {
        Console.WriteLine("Welcome to the journal program");
        Console.WriteLine("Please select one of the following choices");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");

        useranswer = Console.ReadLine();

        //When user press 1 the program will call the Prompt Generator and will display the prompt
        if (useranswer == "1")
        {
            PromptGenerator newprompt = new();
            string randomPrompt = newprompt.DisplayRandomPrompt();
            Console.WriteLine($"{randomPrompt}");

            //Take the user entry and prompt
            Entry entry = new();
            entry._response = Console.ReadLine();

            entry._prompt = randomPrompt;

            //put all the information inside a string using GetDisplayString()
            string getDisplay = entry.GetDisplayString();

            Journal addToList = new();
            addToList.addEntry(entry);
            
        }
        break;
    }
        
    }
}