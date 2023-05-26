using System.CodeDom.Compiler;

namespace Scripture
{
  public class Scripture
  {
    private List<Word> _words;
    private Reference _reference;
    private string _text;
    private int wordCountMax;
    private int wordCountTotal;
    public Scripture() { }
    public Scripture(Reference scripture)
    {
      _words = new List<Word>();
      _reference = new Reference(scripture.GetBook(), scripture.GetChapter(), scripture.GetVerse(), scripture.GetVerseText());
      MakeWordsList(_reference.GetVerseText());
      wordCountTotal = 0;
    }

    public void MakeWordsList(string verseText)
    {
      // turn our verse into a list of words with if they are shown or not
      string[] wordArr = verseText.Split().ToArray();
      wordCountMax = wordArr.Length - 1;
      foreach (string word in wordArr)
      {
        _words.Add(new Word(word, true));
      }
    }

    public void HideWords()
    {
      // get words that are not hidden by index
      // and put them into a new array
      // run a random number generator based on the
      // length of the array and then use the index
      // to hide a word in the list.  If a word is hidden
      // mark the Word hidden in the Word class
      List<int> indexes = new List<int>();
      int randNum;
      int[] removedIndexes = new int[3];

      foreach (var word in _words)
      {

        if (word.GetIsShown() == true)
        {
          indexes.Add(_words.IndexOf(word));
        }
      }

      // get three random indexes and hide them
      if (indexes.Count > 3)
      {
        for (int i = 0; i < 3; i++)
        {
          Random rand = new Random();
          randNum = rand.Next(indexes.Count);
          removedIndexes[i] = indexes[randNum];
          indexes.RemoveAt(randNum);
          wordCountTotal++;
        }
      }
      // if less than 3 items in indexes then hide what is left
      else
      {
        for (int i = 0; i < indexes.Count; i++)
        {
          Random rand = new Random();
          randNum = rand.Next(indexes.Count);
          removedIndexes[i] = indexes[randNum];
          indexes.RemoveAt(randNum);
        }
      }

      for (int i = 0; i < removedIndexes.Length; i++)
      {
        _words[removedIndexes[i]].SetIsShown(false);
      }
    }

    public string GetRenderedText()
    {
      // loop through all the words in _words.
      // if a word is set to be shown add it to _text
      // if set to not be shown replace word with a
      // number of underscores equal to the words length
      // and add to text and return _text

      // start by adding our scripture book chapter and verse to the text
      _text = $"{_reference.GetBook()} {_reference.GetChapter()} : {_reference.GetVerse()} ";

      foreach (var word in _words)
      {
        if (word.GetIsShown() == true)
        {
          _text += word.GetWord() + " ";
        }
        else
        {
          _text += GeneratedUnderlines(word.GetWord()) + " ";
        }
      }
      return _text;
    }

    // takes the number of characters in a word and and instead
    // generates that many underline characters and adds them to
    // text instead
    public string GeneratedUnderlines(string word)
    {
      string underlines = "";
      for (int i = 0; i < word.Length; i++)
      {
        underlines += "_";
      }
      return underlines;
    }

    // check if the scripture is completely hidden or not
    // this works by using a basic counting system where every
    // time a word is hidden the count of hidden words increases
    // and if that count equals or exceeds the number
    // of words in a scripture then it is completely
    // hidden
    //TODO: Make this work
    public bool IsCompletelyHidden()
    {
      if (wordCountTotal >= wordCountMax)
      {
        return true;
      }
      else
      {
        return false;
      }
    }

  }
}
