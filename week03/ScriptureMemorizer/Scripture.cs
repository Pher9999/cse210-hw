public class Scripture()
{
    Reference _reference = new Reference();
    List<Word> _words = new List<Word>();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        // Split the text into words and create Word objects
        string[] wordArray = text.Split(' ');
        _words = wordArray.ToList();
    }

    public void HideRandomWord()
    {
        // Randomly select a Word object and call its Hide method
    }

    public string GetDisplayText()
    {
        // Get the display text from the Reference and concatenate it with the display text of each Word
        return "";
    }

    public bool IsCompletelyHidden()
    {
        // Check if all Word objects are hidden
    }





}