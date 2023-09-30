public class Reference
{
    private string _book;
    private int _chapter;
    private int _firstVerse;
    private int _endVerse;

    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _firstVerse = verse;
    }

    public Reference(string book, int chapter, int verse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _firstVerse = verse;
        _endVerse = endVerse;
    }
    public string GetReference()
    {
        if(_endVerse == 0)
        {
            return($"{_book}{_chapter}:{_firstVerse}");
         }
        else
        {
            return($"{_book}{_chapter}:{_firstVerse}-{_endVerse}");
        }
    }
}