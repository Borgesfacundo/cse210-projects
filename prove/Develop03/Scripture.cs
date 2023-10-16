class Scripture
{
    //This list will store each Word._word
    private List<Word> _scripture;
    Reference _Reference;
    private string _text;

    //Constructor passing scripture reference and the text
    public Scripture(Reference Reference, string text)
    {
        _text = text;
        _Reference = Reference;
    }
}