using System.Collections.Generic;

namespace CostTracker.Models 
{
  public class CalculateBread
  {
    private int _breadsBought;

    public int BreadsBought
    {
      get { return _breadsBought;}
      set { _breadsBought = value; }
    }
    public void SetBreadBought(int newValue)
    {
      _breadsBought = newValue;
    }

    private int _totalCost;
    public int TotalCost
    {
      get { return _totalCost; }
      set {_totalCost = value; }
    }
    
    public void MultiplyBread() {
      _totalCost = BreadsBought * 5;
    }

  }
}
