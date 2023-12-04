class Comment
{
    private string _cAuthor;
    private string _commentText;

    public Comment(string author, string commentText)
    {
        _cAuthor = author;
        _commentText = commentText;
    }
    public string ToString()
    {
        return $"{_cAuthor}, {_commentText}";
    }
}