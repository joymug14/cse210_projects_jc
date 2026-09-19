public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        string[] wordArray = text.Split(" ");
        foreach (string wordStr in wordArray)
        {
            Word newWord = new Word(wordStr);
            _words.Add(newWord);
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();
        int hiddenCount = 0;
        
        while (hiddenCount < numberToHide)
        {
            if (IsCompletelyHidden())
            {
                break;
            }
            int index = random.Next(_words.Count);
            if (!_words[index].IsHidden())
            {
                _words[index].Hide();
                hiddenCount ++;
            }
        }
    }
    public string GetDisplayText()
    {
        string display = _reference.GetDisplayText()+ "\n";
        foreach (Word word in _words)
        {
            display += word.GetDisplayText() + " ";
        }
        return display;
    }
    public bool IsCompletelyHidden()
    {
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