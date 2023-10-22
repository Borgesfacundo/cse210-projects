class Reference 
{
    private string _book;
    private string _chapter;
    private string _verse;
    private string _endVerse = "0";

    public Reference(string book, string chapter, string verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
    }
    public Reference(string book, string chapter, string verse, string endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = endVerse;
    }

    public string GetDisplayReference()
    {
        string renderText = "";
        if (_endVerse == "0")
        {
            renderText = $"{_book} {_chapter}:{_verse}";
        }
        else if (_endVerse != "0")
        {
            renderText = $"{_book} {_chapter}:{_verse}-{_endVerse}";
        }
        return renderText;
    }
}