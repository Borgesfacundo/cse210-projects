class Entry 
{


    //Prompt
    public string _prompt = "";

    //Response
    public string _response = "";

    public string _dateText = "";
    
    
    public string GetDisplayString()
    {

        //This string will be used to save the string in a file
       // string journalSave = $"{_dateText}, Prompt: {_prompt}, {_response},";
        //this will be displayed
        string journalEntry = $"{_dateText} Prompt: {_prompt} {_response}";
       
        return journalEntry;
    }

    public string GetSaveText()
    {
        return $"{_dateText},{_prompt},{_response}";
    }
    //public override string ToString()
    //{
    //    return GetDisplayString();
    //}
}