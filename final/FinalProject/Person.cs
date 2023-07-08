public abstract class Person{
  private string _name;
  private List<Card> _cards;
  private int _handValue; // total int value of cards in hand

  public Person(){

  }

  public virtual void Hit(){}

  public virtual void Stand(){}

  public void CalcHandValue(){}

  public void SetName(string name){ _name = name; }

  public string GetName(){ return _name; }

}
