using System.IO;
using System.Runtime.InteropServices;

public class Journal
{
  public  List<Entry> _entries = new List<Entry>();

  public void AddEntry(Entry newEntry)
  {
    _entries.Add(newEntry);
  }

  public void Display()
   {
    foreach (Entry _entry in _entries)
    {
     Console.WriteLine($"{_entry._date}");
     Console.WriteLine($"{_entry._promptText}");
     Console.WriteLine($"{_entry._entryText}");
    }
   }

   public void SaveToFile(string file)
   {
      using(StreamWriter keeper = new StreamWriter(file))
      {
        foreach (var entry in _entries)
        {
          keeper.WriteLine(entry._date);
          keeper.WriteLine(entry._promptText);
          keeper.WriteLine(entry._entryText);
          keeper.WriteLine();
        }
        
    }
   }

   public void LoadFromFile(string choice, List<Entry> _entries){


   using (StreamReader reader = new StreamReader(choice))
   {
    string _date, _promptText, _entryText;
    while (!reader.EndOfStream)
    {
      _date = reader.ReadLine();
      _promptText = reader.ReadLine();
      _entryText = reader.ReadLine();

      DateTime parsing = DateTime.Parse(_date);

      Entry keptEntry = new Entry
      {
        _date = parsing,
        _entryText = _entryText,
        _promptText = _promptText,
      };
      _entries.Add(keptEntry);
      reader.ReadLine();
    }

   }
   }
    
}
