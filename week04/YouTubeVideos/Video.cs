public class Video
{
    private string _title;
    private string _author;
    private int _length;

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
        return $"Title: {_title}\nAuthor: {_author}\nLength: {_length} seconds";
    }

    public int GetNumOfComments()
    {
        return _comment.Count();
    }

}