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
            //new List to veryfi if word is hidden
            List<Word> isVisible = new List<Word>();

            //iterate thru words List
            for (int a = 0; a < words.Count; a++)
            {
                if (words[a].IsHidden() == false)
                {
                    isVisible.Add(words[a]);
                }
            }
            Random random = new();

            //Choose 3 random words inside the list
            int index = random.Next(isVisible.Count);

            int indexToAdd = words.IndexOf(isVisible[index]);  // index is 1

            //Hide a word
            words[indexToAdd].Hide();
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