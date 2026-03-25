public class Scripture
{
    Reference _reference = new Reference();
    List<Word> _words = new List<Word>();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        // Split the text into words and create Word objects
        string[] wordArray = text.Split(' ');
        foreach (string word in wordArray)
        {
            _words.Add(new Word(word));
        }
    }

    public void HideRandomWord()
    {
        // Randomly select a Word object and call its Hide method
        Random _randomnumber = new Random();
        int index = _randomnumber.Next(_words.Count);
        _words[index].Hide();
    }

    public string GetDisplayText()
    {
        // Get the display text from the Reference and concatenate it with the display text of each Word
        string displayText = _reference.GetDisplayText();
        foreach (Word word in _words)
        {
            displayText += " " + word.GetDisplayText();
        }
        return displayText;

    }

    public bool IsCompletelyHidden()
    {
        // Check if all Word objects are hidden
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;

    }





}