class ListingActivity: Activity{
  private List<string> _listQuestions;
  private int _countListings;

  public ListingActivity(string startingMessage, string endingMessage, int activityTime):
                    base(startingMessage, endingMessage, activityTime){

  }

  public string GetListQuestion(){
    return string.Empty;
  }

  public void RunListing(){

  }
}
