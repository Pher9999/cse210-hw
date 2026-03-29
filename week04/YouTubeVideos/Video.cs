public class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comment = new List<Comment>();
    private string _displayVideo;

    public Video()
    {
        _title = "";
        _author = "";
        _length = 0;
    }

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }

    public string displayVideo()
    {
        _displayVideo = $"Title: {_title}\nAuthor: {_author}\nLength: {_length} seconds\nComments ({_comment.Count()}):\n";
        for (int i = 0; i < _comment.Count(); i++)
        {
            _displayVideo += _comment[i].displayComment();
            _displayVideo += "\n";

        }
        return _displayVideo;
    }

    public int GetNumOfComments()
    {
        return _comment.Count();
    }

    public void AddComment(Comment comment)
    {
        _comment.Add(comment);
    }




}