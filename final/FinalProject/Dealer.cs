public class Dealer : Person{
  private string[] _names = {"Bobby", "Sam", "Susan","Sally"};  // array to randomly chose a name for the dealer from
  private List<Deck> _decks; // list of all the decks the dealer has access to

  public Dealer(int numOfDecks){
    _decks = new();
    // get random name
    Random rand = new();
    int nameIndex = rand.Next(_names.Length);
    base.SetName(_names[nameIndex]);
    // add decks to the dealers group of decks
    for(int i = 0; i < numOfDecks; i++){
      _decks.Add(new Deck());
    }
  }

  public void Deal(){}

  public void Shuffle(){
    foreach(var deck in _decks){
      Random rand = new();
      var d = deck.GetDeck();
      var sd = d.OrderBy( _ => rand.Next()).ToList();
      deck.SetDeck(sd);
    }
  }

  public override void Hit()
  {

  }

  public override void Stand()
  {

  }
}
