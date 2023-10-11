class PromptGenerator
{
    //This list will contain the prompts.
    public List<string> _prompts = new();

    

    public string DisplayRandomPrompt()
    {
        //Adding the prompts.
        _prompts.Add("What was the best part of your day?");
        _prompts.Add("How was your day overall?");
        _prompts.Add("Did you learn something new or gain any valuable insights today?");
        _prompts.Add("What activities or tasks did you find most enjoyable or fulfilling today?");
        _prompts.Add("Were there any moments when you felt particularly stressed or challenged?");

        //Choosing a random prompt from the list.
        var random = new Random();
        int index = random.Next(_prompts.Count);
        string _newPrompt = _prompts[index];
        return _newPrompt;
    }
}