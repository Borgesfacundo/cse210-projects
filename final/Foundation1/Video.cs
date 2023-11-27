
using System.ComponentModel;

class Video
{
    public string _title;
    public string _author;
    public int _length;
    public List<Comment> comments = new List<Comment>();
    public int NumOfComments()
    {
        int number = 0;
        foreach (Comment comment in comments)
        {
            number += 1;
        }
        return number;
    }
}