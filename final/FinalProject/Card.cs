public class Card{
  private string _suit;
  private string _pips; // the number on the card or jack queen king ace
  private Dictionary<string, int> _pipsValue;

  public Card(string suit, string pips){
    _suit = suit;
    _pips = pips;
    _pipsValue = new Dictionary<string, int>();
    _pipsValue.Add("Two", 2);
    _pipsValue.Add("Three", 3);
    _pipsValue.Add("Four", 4);
    _pipsValue.Add("Five", 5);
    _pipsValue.Add("Six", 6);
    _pipsValue.Add("Seven", 7);
    _pipsValue.Add("Eight", 8);
    _pipsValue.Add("Nine", 9);
    _pipsValue.Add("Ten", 10);
    _pipsValue.Add("Jack", 10);
    _pipsValue.Add("Queen", 10);
    _pipsValue.Add("King", 10);
  }
  public int HandleAces(int handTotal){
    if(handTotal > 10){
      return 1;
    } else {
      return 11;
    }
  }

  public string GetCardSuit(){
    return _suit;
  }

  public string GetCardValue(){
    return _pips;
  }
}
