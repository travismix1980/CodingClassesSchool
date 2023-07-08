public class Dealer : Person{
  private readonly string[] _names = {"Bobby", "Sam", "Susan","Sally"};  // array to randomly chose a name for the dealer from
  private List<Deck> _decks; // list of all the decks the dealer has access to

  public Dealer(){
    // get random name
    Random rand = new();
    int nameIndex = rand.Next(_names.Length);
    base.SetName(_names[nameIndex]);
  }

  public void Deal(){}

  public void Shuffle(){}

  public override void Hit()
  {

  }

  public override void Stand()
  {

  }
}
