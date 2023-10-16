class Word
{
    private string _word;
    private bool _hide;

    private string _underscore = "";

    //This constructor is setting the word
    public Word(string word)
    {
        _word = word;
    }

    //Turn _hide true
    public void Hide()
    {
        _hide =  true;
    }

    public string Show()
    {
        // _hide is true, replace _word for udnerscore.
        if (_hide)
        {
            //Get the length of the word
            int length = _word.Length;

            //Create a string for underscore (same lenght than _word).
            for (int i = 0; i < length; i++)
            {
                _underscore += "_";
            }
            return _underscore;
        }
        //If _hide is false, will return the word normally.
        else 
        {
            return _word;
        }
    }
    //This Method is checking if the word were replaced for underscore to choose another to replace
    public bool IsHidden()
    {
        return _hide;
    }
}   