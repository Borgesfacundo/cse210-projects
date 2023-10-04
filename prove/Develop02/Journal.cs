//
using System.IO; 

class Journal
{
    public List<string> entries = new();

    public void addEntry(Entry entry)
    {
        string getEntry = entry.GetDisplayString();
        
        entries.Add(getEntry);
    }

    public void display()
    {
        //foreach loop to display every element in the current list.
        foreach (string line in entries)
        {
            Console.WriteLine($"{line}");
        }
    }

    public void load(string filename)
    {
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            //string[] parts = line.Split(",");

            //string firstName = parts[0];
            //string lastName = parts[1];
        }
    }

    void save(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            // You can add text to the file with the WriteLine method
            outputFile.WriteLine($"{entries}");
    
            // You can use the $ and include variables just like with Console.WriteLine
            //string color = "Blue";
            //
        }
    }
}    