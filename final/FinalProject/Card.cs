public class Card{
  private string _suit;
  private string _pips; // the number on the card or jack queen king ace
  private Dictionary<string, int> _pipsValue;

  public Card(string suit, string pips){
    _suit = suit;
    _pips = pips;

  }
  public int HandleAces(){ return 0; }
}
