namespace Classes
{

    class Entry
    {   
        public string _prompt = "";
        public string _entry = "";
        public string _date = "";
        public string _title = "";
        

    public Entry(string ent_title, string ent_date, string ent_prompt, string ent_entry)
    {
        _title = ent_title;
        _date = ent_date;
        _prompt = ent_prompt;
        _entry  = ent_entry;
    }
    public void ShowEntryDetails()
    {
        Console.WriteLine($"\nTitle: {_title}");
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompt: {_prompt}");
        Console.WriteLine($"Entry: {_entry}");
    }

    }
}