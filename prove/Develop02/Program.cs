using System;


//Date
DateTime theCurrentTime = DateTime.Now;

string useranswer = "0";
string userName = "username";
// create an object from the Journal class to use it through the if statement after
Journal addToList = new();
string filename = "";


while (useranswer != "5")
{
    Console.WriteLine("Welcome to the journal program");
    Console.WriteLine("Please select one of the following choices");
    Console.WriteLine("1. Write");
    Console.WriteLine("2. Display");
    Console.WriteLine("3. Load");
    Console.WriteLine("4. Save");
    Console.WriteLine("5. Quit");
    Console.WriteLine("What would you like to do?");

    useranswer = Console.ReadLine();

    //When user press 1 the program will call the Prompt Generator and will display the prompt
    if (useranswer == "1")
    {
        //Asking the user for his/her name
        Console.WriteLine("What is your name?");
        userName = Console.ReadLine();


        //Create and display a random prompt
        PromptGenerator newprompt = new();
        string randomPrompt = newprompt.DisplayRandomPrompt();
        Console.WriteLine($"{randomPrompt}");
        Entry entry = new();

        //Take the user entry and prompt
        entry._name = userName;

        entry._response = Console.ReadLine();

        entry._prompt = randomPrompt;

        entry._dateText = theCurrentTime.ToShortDateString();


        //put all the information inside a string using GetDisplayString()
        entry.GetDisplayString();

        //Put the informarion inside a List.
        addToList.AddEntry(entry);

    }
    if (useranswer == "2")
    {
        addToList.Display();
    }
    if (useranswer == "3")
    {
        Console.WriteLine("What is the filename?");
        filename = Console.ReadLine();
        addToList.Load(filename);
    }
    if (useranswer == "4")
    {
        Console.WriteLine("What is the filename?");
        filename = Console.ReadLine();
        addToList.Save(filename);
    }
    if (useranswer == "5")
    {
        break;
    }
    else if ((useranswer != "1") && (useranswer != "2") && (useranswer != "3") && (useranswer != "4") && (useranswer != "5"))
    {
        Console.WriteLine("Please enter a valid answer");
    }

}
