
public class Journal
{
  
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
       
    }
    public void SaveToFile(string file)
    {
        using (StreamWriter outputFile = new StreamWriter(file))
        {    
            foreach (Entry e in _entries)
            {
                outputFile.WriteLine($"{e._date}|{e._promptText}|{e._entryText}");
            }
            
        }
        
    }

    public void LoadFromFile(string file)
    {
        string[] lines = System.IO.File.ReadAllLines(file);

        foreach (string line in lines)
        {
            Entry e = new Entry();
            string[] parts = line.Split("|");
            
            e._date = parts[0];
            e._promptText = parts[1];
            e._entryText = parts[2];       
            
        }
    }


    public void DisplayAll()
        {
            int entryCount = 0;
            int totalCount = _entries.Count();

            foreach (Entry e in _entries)
            {
                if(entryCount == totalCount -1)
                {
                    //write a divider for entries at top and bottom for last entry
                    Console.WriteLine("=========================================");
                    e.Display();
                    Console.WriteLine("=========================================");
                }
                else
                {
                    // write a divider to top of each entry to seperate.
                    Console.WriteLine("=========================================");
                    e.Display();
                    Console.WriteLine("=========================================");
                }
                
                
            }
            
        }
        
}