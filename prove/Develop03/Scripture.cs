// Scripture class represents the scripture itself
class Scripture
{
    private string _reference;
    private string _scriptText;

    public Scripture()
    {
        _reference = "";
        _scriptText = "";
    }

    public Scripture(string ref1, string word1)
    {
        _reference = ref1;
        _scriptText = word1;
    }

    public void SetScriptureParts()
    {

    }
    public string GetScriptureParts()
    {
        return ($"{_reference} {_scriptText}");
    }

    public void DisplayFullScripture()
    {
        Console.WriteLine(GetScriptureParts());
    }
}