public class Comment
{
    string _commenterName;
    string _commentText;

    public Comment()
    {
        _commenterName = "";
        _commentText = "";
    }
    public Comment(string commentName, string commentText)
    {
        _commenterName = commentName;
        _commentText = commentText;
    }

    public string displayComment()
    {
        return $"Comment by {_commenterName}: \"{_commentText}\"";
    }
}