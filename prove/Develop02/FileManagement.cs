namespace JournalApp
{
  // this Class handles saving and loading to text files
  // to optimize I really should make this static
  public class FileManagement
  {
    // list to save all of our entries into when we bring them in from journal
    public List<Entry> SaveList { get; set; }

    // what it says it holds file names to save and load files with
    public string FileName { get; set; }

    // this is a constructor for the FileManagement Class
    // it is what runs when we call new to instantiate
    // a new object.  This one I used for loading
    // files as it just wants the fileName
    public FileManagement(string fileName)
    {
      FileName = fileName;
    }

    // this is a constructor for the FileManagement Class
    // it is what runs when we call new to instantiate
    // a new object.  This one is for saving files which is why it
    // has the fileName to save and the listToSave parameter to
    // save the list to text file
    public FileManagement(string fileName, List<Entry> listToSave)
    {
      FileName = fileName;
      SaveList = listToSave;
    }

    // saves the journal entries to text file
    public void SaveFile()
    {
      using StreamWriter outputFile = new(FileName);
      foreach (var line in SaveList)
      {
        outputFile.WriteLine(line.FinalizedEntry);
      }
    }

    // loads a text file into a List and then returns the list
    // to our main list for storing journal entries
    public List<Entry> LoadFile()
    {
      List<Entry> returnList = new();
      foreach (string line in File.ReadAllLines(FileName))
      {
        returnList.Add(new Entry(line));
      }

      return returnList;
    }
  }
}
