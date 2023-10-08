class Entry 
{


    //Prompt
    public string _prompt = "";

    //Response
    public string _response = "";

    public string _dateText = "";

    public string _name = "0";
    
    
    public string GetDisplayString()
    {
        //this will be displayed
        string journalEntry = $"{_dateText} Prompt: {_prompt} \n{_name}: {_response}";
       
        return journalEntry;
    }

    public string GetSaveText()
    {
        return $"{_dateText},{_prompt},{_name},{_response}";
    }
    //public override string ToString()
    //{
    //    return GetDisplayString();
    //}
}