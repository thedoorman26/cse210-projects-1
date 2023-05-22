using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Scripture Memorizer App!");
        
        Reference ref1 = new Reference();
        ref1.SetReferenceSingle("John", 3, 16);

        ref1.DisplayReference();

        Word word1 = new Word();
        word1.SetScriptureWords("This is just a test.");

        word1.DisplayScriptureWords();
           
        Scripture script1 = new Scripture();
        script1.GetScriptureParts();
        script1.DisplayFullScripture();
    }
}