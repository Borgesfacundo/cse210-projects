class Comment
{
    // SMT should be private and initialized with constructor parameters.
    public string _cAuthor;
    public string _commentText;

    // SMT rename this to ToString(). You're not adding a comment here.
    public string AddComment()
    {
        return $"{_cAuthor}, {_commentText}";
    }
}