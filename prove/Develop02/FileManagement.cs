namespace JournalApp
{
  public class FileManagement
  {
    public List<Entry> SaveList { get; set; }
    public string FileName { get; set; }

    public FileManagement(string fileName)
    {
      FileName = fileName;
    }

    public FileManagement(string fileName, List<Entry> listToSave)
    {
      FileName = fileName;
      SaveList = listToSave;
    }

    public void SaveFile()
    {

      using StreamWriter outputFile = new(FileName);
      foreach (var line in SaveList)
      {
        outputFile.WriteLine(line.FinalizedEntry);
      }
    }


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
