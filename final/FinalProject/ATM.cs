public class ATM{
  private double _moneyStored;

  public ATM(){}

  public double GetMoneyStored(){ return _moneyStored; }

  public void SetMoneyStored(double money){
    _moneyStored += money;
  }
}
