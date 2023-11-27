class Comment
{
    public string _cAuthor;
    public string _commentText;

    public string AddComment()
    {
        return $"{_cAuthor}, {_commentText}";
    }
}