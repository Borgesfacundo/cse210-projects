
using System.ComponentModel;

class Video
{
    // SMT should be private and initialized with constructor parameters.
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

    // SMT add a ToString() method that returns a formatted string that can be printed using Console. See StringBuilder
}