class Scripture
{
    //This list will store each Word._word
    private List<Word> words = new List<Word>();
    Reference _Reference;


    //Constructor passing scripture reference and the text
    public Scripture(Reference Reference, string text)
    {
        string[] _words = text.Split(' ');
        foreach (string word in _words)
        {
            words.Add(new Word(word));
        }
        _Reference = Reference;
    }

    public void HideWords()
    {
        //while loop 
        for (int i = 0; i < 3; i++)
        {
            Random random = new();
            
            //Choose 3 random words inside the list
            int index = random.Next(words.Count);  
            //Hide a word
            words[index].Hide();
            
        }
    }
    //This method would get the text after passigng thru Word Class and return it
    public string GetRenderedText()
    {
        string renderText = _Reference.GetDisplayReference();
        renderText += "\n";

        //Pass each word into Word Class and add it to the Scripture List
        foreach (Word _word in this.words) 
        {
            renderText += $"{_word.Show()} ";
        }

        return renderText;
    }

    public bool AllHidden()
    {
        bool result = true;
        for (int i = 0; i < words.Count; i++)
        {
            if (words[i].IsHidden() == false)
            {
                result = false;
                break;
            }
        }
        return result;
    }
    
}