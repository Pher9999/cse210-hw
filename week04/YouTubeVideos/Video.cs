public class Video
{
    string _title;
    string _author;
    int _length;

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

}