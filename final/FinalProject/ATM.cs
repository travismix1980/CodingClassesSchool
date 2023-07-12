public class ATM{
  private double _moneyStored;

  public ATM(){}

  public double GetMoneyStored(){ return _moneyStored; }

  public void DepositMoney(double money){
    _moneyStored += money;
  }

// TODO: fix so it doesn't allow withdrawing more than you have
  public void WithdrawMoney(double money){
    _moneyStored -= money;
  }
}
