class Scripture
{
    //This list will store each Word._word
    private List<Word> words = new List<Word>();
    Reference _Reference;

    private List<Word> visibleWords = new List<Word>();


    //Constructor passing scripture reference and the text
    public Scripture(Reference Reference, string text)
    {
        string[] _words = text.Split(' ');
        foreach (string word in _words)
        {
            words.Add(new Word(word));
        }
        _Reference = Reference;
        // new List
        foreach (string word in _words)
        {
            //add all words
            visibleWords.Add(new Word(word));
        }
    }

    public void HideWords()
    {
        //while loop 
        for (int i = 0; i < 3; i++)
        {
            Random random = new();
            for (int a = 0; a < visibleWords.Count; a++)
            {
                //if a word has a Hide() true will remove it from the new list
                if (words[a].IsHidden() == true)
                {
                    visibleWords.Remove(visibleWords[a]);
                }
                    //Choose 3 random words inside the list
                    int index = random.Next(visibleWords.Count);

                    
                    Word searchString = visibleWords[index];
                    int index2 = words.IndexOf(searchString);  // index is 1

                    //Hide a word
                    words[index2].Hide();
            }
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