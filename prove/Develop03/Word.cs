// Word class represents a single word in the scripture
class Word
{
   private string _word;
   private bool _isHidden;
    

    private List<Word> scriptWords = new List<Word>();
    public Word()
    {
        _word = "";
        
    }
    public Word(string word)
    {
        _word = word;
        
    }


    public void SetScriptureWords(string word) 
        {
            _word = word;
        }
    public string GetScriptureWords()
    {
        return ($"{_word}.");
    }
    public void DisplayScriptureWords()
        {
            Console.WriteLine(GetScriptureWords());
        }

}

