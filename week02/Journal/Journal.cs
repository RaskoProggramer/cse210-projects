using System.IO;
using System.Text.Json;
class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }

    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
            Console.WriteLine();
        }
    }

    public void SaveToFile(string file)
    {
        string jsonString = JsonSerializer.Serialize(_entries);

        File.WriteAllText(file, jsonString);
    }

    public void LoadFromFile(string file)
    {
        string jsonString = File.ReadAllText(file);

        List<Entry> loadedEntries = JsonSerializer.Deserialize<List<Entry>>(jsonString);
        _entries = loadedEntries;
    }
    
}