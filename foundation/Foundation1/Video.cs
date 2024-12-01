using System.Collections.Generic;

public class Video
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int Length { get; set; }
    private List<Comment> _Comments { get; set; }

    public Video(string title, string author, int length)
    {
        Title = title;
        Author = author;
        Length = length;
        _Comments = new List<Comment>();
    }

    public void AddComment(Comment comment)
    {
        _Comments.Add(comment);
    }

    public int GetCommentCount()
    {
        return _Comments.Count;
    }

    public List<Comment> GetComments()
    {
        return _Comments;
    }
}
