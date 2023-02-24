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

    private int _totalDiscount;
    public int TotalDiscount
    {
      get { return _totalDiscount; }
      set { _totalDiscount = value; }
    }

    public void SetDiscount() {
      if (BreadsBought < 3) 
      { //User did not buy more than 3 pieces of bread, therfore no discount
        _totalDiscount = 0; 
      }
      else if (BreadsBought >= 3) 
      { //User buys more than 3 pieces of bread, calculate total discount 
        _totalDiscount = (BreadsBought / 3) * 5;
      }
      else {
        BreadsBought = 0; // If there is an exepected error, BreadsBought will be set to zero as to not effect the customer.
      }
    }

    public int CalcualateCost()
    {
      return TotalCost - TotalDiscount;
    }

  }
}
