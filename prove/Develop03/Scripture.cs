class Scripture
{
    //This list will store each Word._word
    private List<Word> _scriptureWords = new List<Word>();
    Reference _Reference;
    private string _text;
    private string _display;
    private bool _endProgram;


    //Constructor passing scripture reference and the text
    public Scripture(Reference Reference, string text)
    {
        _text = text;
        _Reference = Reference;
    }

    public void HideWords()
    {
        // Assuming you have a List<Word> called words and you want to hide
        // three words each time

        // Hide some of the visible Words randomly
        for (int i = 0; i < 3; i++)
        {
            
            //Random (Next line i created dont know if its right)
            Random random = new();
            //Choose 3 random words inside the list
            int index = random.Next(_scriptureWords.Count);
            //Turn boolean hide true
            _scriptureWords[index].IsHidden();
        }
    }
    //This method would get the text after passigng thru Word Class and return it
    public string GetRenderedText()
    {
        //sepparating each word of _text
        string[] words = _text.Split(' ');

        //Pass each word into Word Class and add it to the Scripture List
        foreach (string _word in words) 
        {
            Word word = new(_word);
            word.Show();
            _scriptureWords.Add(word);
        }

        //Displaying the result
        _display = $"{_Reference} : {_scriptureWords}";
        
        return _display;
    }

    public bool AllHidden()
    {
        
        bool _endProgram = true;
        return _endProgram;
    }
}