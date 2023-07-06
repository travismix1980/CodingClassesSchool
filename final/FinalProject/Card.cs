public class Card{
  private string _suit;
  private string _pips; // the number on the card or jack queen king ace
  private Dictionary<string, int> _pipsValue;

  public Card(){}
  public int HandleAces(){ return 0; }
}
