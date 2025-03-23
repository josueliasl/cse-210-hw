using System;

public class References
{
    private string _book;
    private int _chapter;
    private int _startVerse;
    private int _verse;
    private int _endVerse;

    public References(string _book, int _chapter, int _verse)
    {
        this._book = _book;
        this._chapter = _chapter;
        this._verse = _verse;
    }
    public References(string _book, int _chapter, int _startVerse, int _endVerse)
    {
        this._book = _book;
        this._chapter = _chapter;
        this._startVerse = _startVerse;
        this._endVerse = _endVerse;
    }
    public string GetBookName()
    {
        return _book;
    }
    public int GetChapter()
    {
        return _chapter;
    }
    public int GetStartVerse()
    {
        return _startVerse;
    }
    public int GetVerse()
    {
        return _verse;
    }
    public int GetEndVerse()
    {
        return _endVerse;
    }
    public string BookChapterVerse()
    {
        return _book + " " + _chapter + ":" + " " + _verse;
    }
    public string BookChapterStartEndVerse()
    {
        return _book + " " + _chapter + ":" + " " + _startVerse + "-" + _endVerse;
    }
}