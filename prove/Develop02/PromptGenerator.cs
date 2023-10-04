class PromptGenerator
{
    //This list will contain the prompts.
    public List<string> _prompts = new();

    public string DisplayRandomPrompt()
    {
        //Adding the prompts.
        _prompts.Add("A");
        _prompts.Add("B");
        _prompts.Add("C");
        _prompts.Add("D");
        _prompts.Add("E");

        //Choosing a random prompt from the list.
        var random = new Random();
        int index = random.Next(_prompts.Count);
        string _newPrompt = _prompts[index];
        return _newPrompt;
    }
}