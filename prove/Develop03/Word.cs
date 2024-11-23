using System;
using System.Reflection.Metadata;

public class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    public void Hide()
    {
        _isHidden = true;

    }

    public void Show()
    {
        _isHidden = false;

    }

    public bool IsHidden()
    {
        return _isHidden;
    }

    public string GetDisplayText()
    {

        if (_isHidden)
        {
            return string.Join(" ", _text.Select(c => "_"));
        }
        else
        {
            return _text;
        }
    }

    public string GetOriginalText()
    {
        return _text;
    }
}