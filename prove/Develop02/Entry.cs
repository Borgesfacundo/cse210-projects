class Entry 
{
    //Date
    public static DateTime theCurrentTime = DateTime.Now;
    public string dateText = theCurrentTime.ToShortDateString();

    //Prompt
    public  string _prompt = "";

    //Response
    public  string _response = "";

    public string GetDisplayString()
    {
        string journalEntry = $"{dateText} - {_prompt} - {_response}";
       
        return journalEntry;
    }
}