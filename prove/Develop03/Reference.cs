// Reference class represents the scripture reference
class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;

    public Reference()
    {
        _book = "";
        _chapter = 0;
        _verse = 0;
        _endVerse = 0;
    }

    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
    }

    public Reference(string book, int chapter, int verse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = endVerse;
    }

    public void SetReferenceSingle(string book, int chapter, int verse)
    {
         _book = book;
        _chapter = chapter;
        _verse = verse;
    }
    public string GetReference() 
    {
        return ($"{_book} {_chapter}:{_verse}");
    }

    public void DisplayReference()
    {
        Console.WriteLine(GetReference());
    }
    
}

