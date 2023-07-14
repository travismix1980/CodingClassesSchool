public abstract class Person{
  private string _name;
  private List<Card> _cards;
  protected int _handValue; // total int value of cards in hand
  protected Card[] _hand;

  public Person(){

  }

  public virtual void Hit(){}

  public virtual void Stand(){}

  public void CalcHandValue(Card[] hand){}

  public void SetName(string name){ _name = name; }

  public string GetName(){ return _name; }

// TODO: finish the ability to get all the current cards
  protected Card[] GetCurrentCards(){
    return _hand;
  }
}
