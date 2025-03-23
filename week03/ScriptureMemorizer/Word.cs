using System;

public class Words
{
    private string _text;
    private bool _isHidden;

    public Words(string _text)
    {
        this._text = _text;
        this._isHidden = false;
    }
    public string GetText()
    {
        if (_isHidden)
        {
            return new string('_', _text.Length);
        }
        else 
        {
            return _text;
        }
    }
    public bool HiddenOrShown()
    {
        return _isHidden;
    }
    public void Toggling()
    {
        _isHidden = !_isHidden;
    }
}