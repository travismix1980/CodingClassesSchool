class Animation{
  private char[] _spinnerFrames = {'|',  '/', '-', '\\', '|', '/', '-', '\\'};
  private List<int> _countDown = new List<int>();

  public Animation(){
  }

  public void SetCountdown(int max){
    // incase its already holding something
    _countDown.Clear();
    for(int i  = 1; i < max; i++){
      _countDown.Add(i);
    }
  }

  public void PlayCountdownAnimation(int maxCount, int frameTime=1000){
    for(int i = maxCount; i > 0; i--){
      Console.Write(i);
      Thread.Sleep(frameTime);
      Console.Write("\b \b");
    }
  }

  public void PlaySpinnerAnimation(int frameTime, int animationTime){

    DateTime start = DateTime.Now;
    DateTime end = start.AddMilliseconds(animationTime);

    while(DateTime.Now < end){
      for(int i = 0; i < _spinnerFrames.Length; i++){
        if(i < _spinnerFrames.Length){
          Console.Write(_spinnerFrames[i]);
          Thread.Sleep(frameTime);
          Console.Write("\b \b");
        }
        else {
          i = 0;
          Console.Write(_spinnerFrames[i]);
          Thread.Sleep(frameTime);
          Console.Write("\b \b");
        }
      }
    }
  }
}
