using System;
using System.Collections.Generic;
using System.Linq; // Added for advanced list filtering (exceeding requirements)

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        // Split the raw text string by spaces to create individual Word objects
        string[] splitText = text.Split(' ');
        foreach (string wordString in splitText)
        {
            _words.Add(new Word(wordString));
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();
        
        // Exceeding Requirements logic: Filter for words that are NOT already hidden
        var unhiddenWords = _words.Where(w => !w.IsHidden()).ToList();

        // Ensure we don't try to hide more words than are left visible
        int wordsToHide = Math.Min(numberToHide, unhiddenWords.Count);

        for (int i = 0; i < wordsToHide; i++)
        {
            int index = random.Next(unhiddenWords.Count);
            unhiddenWords[index].Hide();
            unhiddenWords.RemoveAt(index); // Remove from our temporary list so it can't be selected twice in the same loop
        }
    }

    public string GetDisplayText()
    {
        string scriptureText = "";
        foreach (Word word in _words)
        {
            scriptureText += word.GetDisplayText() + " ";
        }
        
        // Combine the reference and the compiled scripture text
        return $"{_reference.GetDisplayText()} {scriptureText.Trim()}";
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            // If even one word is not hidden, the scripture is not completely hidden
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }
}