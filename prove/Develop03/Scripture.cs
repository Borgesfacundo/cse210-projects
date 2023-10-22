class Scripture
{
    //This list will store each Word._word
    private List<Word> _scriptureWords = new List<Word>();
    Reference _Reference;
    private string _text;
    private string _display;
    private bool _endProgram;
    private string _userAnswer;


    //Constructor passing scripture reference and the text
    public Scripture(Reference Reference, string text)
    {
        _text = text;
        _Reference = Reference;
    }

    public void HideWords()
    {
        //while loop 
        for (int i = 0; i < 3; i++)
        {

                //Random (Next line i created dont know if its right)
                Random random = new();
                //Choose 3 random words inside the list
                int index = random.Next(_scriptureWords.Count);
                _scriptureWords[index].Hide();

        }
    }
    //This method would get the text after passigng thru Word Class and return it
    public string GetRenderedText()
    {
        //Display Reference
        _Reference.GetDisplayReference();

        //sepparating each word of _text
        string[] words = _text.Split(' ');

        //Pass each word into Word Class and add it to the Scripture List
        foreach (string _word in words) 
        {
            Word word = new(_word);
            word.Show();
            _scriptureWords.Add(word);
            _display += $"{word.Show()} ";
        }
            //modify text
            _text = _display;

        return _display;
    }

    public bool AllHidden()
    {
        bool result = true;
        for (int i = 0; i < _scriptureWords.Count; i++)
        {
            if (_scriptureWords[i].IsHidden() == false)
            {
                result = false;
                break;
            }
        }
        return result;
    }

    public void Anything()
    {
        bool condition = false;
        string input = "";
        while (condition)
        {

        }
        do{
            condition = true;
            Console.WriteLine("Type quit to exit");
            input = Console.ReadLine();
        }
        while (input != "quit");
    }
}