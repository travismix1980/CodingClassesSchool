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

// TODO: Make the dealer able to deal a single card
  public void Deal(){
    Console.WriteLine("Dealer deals everyone a card");
  }

  public void Shuffle(){
    foreach(var deck in _decks){
      Random rand = new();
      var d = deck.GetDeck();
      var sd = d.OrderBy( _ => rand.Next()).ToList();
      deck.SetDeck(sd);
    }
  }

//TODO: Finish Dealer Hit and Stand once Dealing Cards is finished
  public override void Hit()
  {
    if(_handValue < 17){
      Console.WriteLine("Dealer Hits");
    }
  }

  public override void Stand()
  {
    if(_handValue > 16){
      Console.WriteLine("Dealer Stands");
    }
  }
}
