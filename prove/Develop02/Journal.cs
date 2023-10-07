//
using System.IO; 

class Journal
{
    public List<Entry> entries = new();

    public void AddEntry(Entry entry)
    {
        entry.GetDisplayString();
        
        entries.Add(entry);
    }

    public void Display()
    {
        //foreach loop to display every element in the current list. // Entry line???
        for (int i = 0; i < entries.Count; i++)
        {
            //string value = entries[i].GetDisplayString();
            //Console.WriteLine($"{entries[i]}");
            Console.WriteLine($"{entries[i].GetDisplayString()}");
           // Console.WriteLine($"{value}");
        }
    }

    public void Load(string filename)
    {
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split(",");

            Entry entry = new();

            entry._dateText = parts[0];
            entry._prompt = parts[1];
            entry._response = parts[2];
            //put all in a string
            AddEntry(entry);
            //entry.GetDisplayString();
        }
    }

    public void Save(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            for (int i = 0; i < entries.Count; i++)
            {
                
                // You can add text to the file with the WriteLine method
                outputFile.WriteLine($"{entries[i].GetSaveText()}");
    
                // You can use the $ and include variables just like with Console.WriteLine
                //string color = "Blue";
                //
            }
            
        }
    }
}    