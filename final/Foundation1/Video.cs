
using System.ComponentModel;
using System.Text;

class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> comments = new List<Comment>();

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }
    public int NumOfComments()
    {
        int number = 0;
        foreach (Comment comment in comments)
        {
            number += 1;
        }
        return number;
    }
    public void AddToList(Comment comment)
    {
        comments.Add(comment);
    }
    public string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"Title: {_title}");
        sb.AppendLine($"Author: {_author}");
        sb.AppendLine($"Length: {_length} seconds");
        sb.AppendLine($"Comments: {comments.Count}");
        foreach (Comment comment in comments)
        {
            sb.AppendLine($"   {comment.ToString()}");
        }
        return sb.ToString();
    }
}