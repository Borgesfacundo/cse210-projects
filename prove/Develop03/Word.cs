class Word
{
    private string _word;
    private bool _hide;

    private string _underscore = "_";


    public Word(string word)
    {
        _word = word;
    }

    //Turn _hide true
    public bool Hide()
    {
        _hide =  true;
        return _hide;
    }

    public string Show()
    {
        if (_hide)
        {
            //Get the length of the word
            int length = _word.Length;
            _word = "";

            //Replace word for underscore (same lenght than _word)
            for (int i = 0; i < length; i++)
            {
                _word += _underscore;
            }
            return _word;
        }
        else 
        {
            return _word;
        }
    }
}   