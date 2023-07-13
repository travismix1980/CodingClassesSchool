public class Money{
  private double _moneyOnPerson;

  public Money(double moneyOnPerson){
    _moneyOnPerson = moneyOnPerson;
  }

  public double GetMoneyOnPerson(){ return _moneyOnPerson; }

  public void SetMoneyOnPerson(double money){ _moneyOnPerson += money; }
}
