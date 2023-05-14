using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Classes
{
    class Journal
    {
        public static string _jEntry = "";
        public static string _filename = "JournalEntries.txt";

    static List<Entry> NewEntry = new List<Entry>();
    public Journal()
    {
        NewEntry = new List<Entry>();        
    }

    public static void addEntry(Entry entry)
    {
        NewEntry.Add(entry);
        //Journal.NewEntry.Add(newEntry);
    }


    public static void JournalEntryDetails()
    {
        Console.WriteLine("\n************** Journal Entry **************");
        
        foreach (Entry e in NewEntry)
        {
            e.ShowEntryDetails();
        }
        Console.WriteLine("\n******************** End ********************");
    }

    public static void CreateFile()
    {
        if (!File.Exists("JournalEntries.txt"))
        {
            File.CreateText("JournalEntries.txt");
        }
    }
    public static void SaveToFile() 
    {
        Console.WriteLine("\nSaving to file...");
        
        using (StreamWriter outputFile = new StreamWriter(Journal._filename))
        {
            foreach (Entry e in NewEntry)
            {
                outputFile.WriteLine($"{e._title}~|~{e._date}~|~{e._prompt}~|~{e._entry}");
            }
        }

        Console.WriteLine("\nFile Saved...");
    }
    public static void ClearFile()
    {
        string response;
        
        Console.WriteLine("Are you sure you want to clear the contents of the journal file? (yes/no)");
        response = Console.ReadLine().Trim().ToLower();

        if (response == "yes")
        {
            File.WriteAllText("JournalEntries.txt", "");
            Console.WriteLine("\nJournal is cleared.");
        }
        else 
        {
            Console.WriteLine("\nJournal was not cleared.");
        }   
    }
    
    public static void ReadFromFile()
    {
        Console.WriteLine("\nReading Saved File...");
        string[] lines = File.ReadAllLines(Journal._filename);

        Console.WriteLine("\n************** Journal Entry **************");
        foreach (string line in lines)
        {
            string[] parts = line.Split("~|~");

            string entryTitle = parts[0];
            string entryDate = parts[1];
            string entryPrompt = parts[2];
            string entryAnswer = parts[3];
            Console.WriteLine($"\nTitle: {entryTitle}");
            Console.WriteLine($"Date: {entryDate}");
            Console.WriteLine($"Prompt: {entryPrompt}");
            Console.WriteLine($"Answer: {entryAnswer}");
        }
        Console.WriteLine("\n******************** End ********************");
    }
    

    }
}