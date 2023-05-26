namespace Scripture
{
  public class Reference
  {
    private string _book;
    private string _chapter;
    private string _verse;
    private string _verseText;

    public Reference() { }
    public Reference(string book, string chapter, string verse, string verseText)
    {
      _book = book;
      _chapter = chapter;
      _verse = verse;
      _verseText = verseText;
    }

    public string GetBook()
    {
      return _book;
    }

    public string GetChapter()
    {
      return _chapter;
    }

    public string GetVerse()
    {
      return _verse;
    }

    public void SetBook(string book)
    {
      _book = book;
    }

    public void SetChapter(string chapter)
    {
      _chapter = chapter;
    }

    public void SetVerse(string verse)
    {
      _verse = verse;
    }

    public string GetVerseText()
    {
      return _verseText;
    }

    public void SetVerseText(string verseText)
    {
      _verseText = verseText;
    }
  }
}
