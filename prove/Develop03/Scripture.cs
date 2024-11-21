using System;
using System.Security.Cryptography.X509Certificates;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = text.Split("").Select(word => new Word(word)).ToList();

    }

    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();
        int hiddenCount = 0;

        while (hiddenCount < numberToHide)
        {
            List<Word> visibleWords = _words.Where(w => !w.IsHidden()).ToList();

            if (visibleWords.Count == 0)
            {
                hiddenCount = numberToHide;
            }
            else
            {
                int randomIndex = random.Next(visibleWords.Count);
                Word wordToHide = visibleWords[randomIndex];
                wordToHide.Hide();
                hiddenCount++;
            }
        }
    }

    public string GetDisplayText()
    {
        string wordsDisplay = string.Join("", _words.Select(w => w.GetDisplayText()));
        return $"{_reference.GetDisplayText()}\n{wordsDisplay}";

    }

    public bool IsCompletelyHidden()
    {
        return _words.All(w => w.IsHidden());

    }
}