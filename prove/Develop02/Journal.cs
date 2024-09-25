public class Journal    
{
    public List<Entry> _entries = new List<Entry>(); // makes as empty list

    public void AddEntry(Entry newEntry)
    {
        // put newEntry into _entries
    }

    public void DisplayAll()
    {
        // display all of the entries in the _entries list (probably need a loop. when you print things to console, don't forget the Diplay funtion in the Entry class. use Entry.Display)
    }

    public void SaveToFile(string file)
    {
        // loop through each item in _entries and save it to a file
    }

    public void LoadFromFile(string file)
    {
        // loop through each line of the file and create Entry objects to put the list in. clear something so we don't get duplicates
    }

}    