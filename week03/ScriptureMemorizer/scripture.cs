// Applies dynamic terminal colors to fade hidden words into dark gray and track memorization progress visually.

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        string[] words = text.Split(' ');

        for (int i = 0; i < words.Length; i++)
        {
            _words.Add(new Word(words[i]));
        }
    }

    public string GetDisplayText()
    {
        string displayText = _reference.GetDisplayText() + "\n";

        foreach (Word word in _words)
        {
            displayText += word.GetDisplayText() + " ";
        }

        return displayText.Trim();
    }
    public void HideRandomWords(int numberToHide)
{
    // 1. Safety check: Are all words already hidden?
    bool allHidden = true;
    foreach (Word word in _words)
    {
        if (!word.GetDisplayText().Contains('_'))
        {
            allHidden = false;
            break; // Found at least one visible word, stop checking
        }
    }

    // If every word is already hidden, exit the method immediately
    if (allHidden)
    {
        return;
    }

    
    Random random = new Random();
    int hiddenCount = 0;

    while (hiddenCount < numberToHide)
    {
        int index = random.Next(_words.Count);
        Word word = _words[index];

        if (!word.GetDisplayText().Contains('_'))
        {
            word.Hide();
            hiddenCount++;
        }
    }
}

public bool IsCompletelyHidden()
{
    foreach (Word word in _words)
    {
        if (!word.GetDisplayText().Contains('_'))
        {
            return false; // Found a word that is still visible
        }
    }
    return true; // Every single word has underscores!
}

public void DisplayColoredScripture()
{
    foreach (Word word in _words)
    {
        // If the word is hidden (contains underscores), make it Dark Gray
        if (word.GetDisplayText().Contains('_'))
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
        }
        else
        {
            // If it's still visible, make it bright White
            Console.ForegroundColor = ConsoleColor.White;
        }

        Console.Write(word.GetDisplayText() + " ");
    }
    Console.ResetColor(); // Reset back to default console colors
}

}