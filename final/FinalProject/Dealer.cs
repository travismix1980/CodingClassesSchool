public class Dealer : Person{
  private string[] _names = {"Bobby", "Sam", "Susan","Sally"};  // array to randomly chose a name for the dealer from
  private List<Card> _decks; // list of all the decks the dealer has access to
  private int _numOfDecks;

  public Dealer(int numOfDecks){
    _numOfDecks = numOfDecks;
    _decks = new();
    // get random name
    Random rand = new();
    int nameIndex = rand.Next(_names.Length);
    base.SetName(_names[nameIndex]);
    // add decks to the dealers group of decks
    SetupDeck();
  }

  public void SetupDeck(){
    _decks.Clear(); // clear _decks so we dont have extra cards
    for(int i = 0; i < _numOfDecks; i++){
      // get a deck and add each card from that deck
      Deck d = new();
      foreach(var c in d.GetDeck()){
        _decks.Add(c);
      }
    }
    // a real dealer would shuffle multiple times a vegas dealer shuffles three times
    Shuffle();
    Shuffle();
    Shuffle();
  }


  public Card Deal(){
    // if not enough cards re setup decks vegas dealers tend to shuffle between
    // 40 and 60 percent of cards remaining I went with 40%
    if(_decks.Count <= (_numOfDecks * 52 * .40)){
      SetupDeck();
    }
    // deal card
    Card c = _decks[0];
    _decks.RemoveAt(0);
    return c;
  }

  public void Shuffle(){
    foreach(var card in _decks){
      Random rand = new();
      _decks = _decks.OrderBy( _ => rand.Next()).ToList();
    }
  }

  public int GetNumOfDecks(){
    return _numOfDecks;
  }
}
