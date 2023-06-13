public abstract class Shape{
  private string _color;

  public Shape(string color){
    _color = color;
  }

  public string GetColor(){
    return _color;
  }

  public void SetColor(string color){
    _color = color;
  }

// it seems to me that a abstract method would work better here
// as we dont have anything to calculate the area with as part of this class
// public abstract double GetArea(); <-- wouldn't that be better than
// the required virtual method below?
  public virtual double GetArea(){

    return 0.0;
  }
}
