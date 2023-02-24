using System.Collections.Generic;

namespace CostTracker.Models
{
  public class CalculatePastry 
  {
    private int _pastriesBought;
    public int PastriesBought {
      get { return _pastriesBought; }
      set { _pastriesBought = value; }
    }

    public void SetPastryBought(int newValue) 
    {
      _pastriesBought = newValue;
    }

    private int _pastryTotalCost;
    public int pastryTotal {
      get { return _pastryTotalCost; }
      set { _pastryTotalCost = value; }
    }

    public void MultiplyPastry()  // Each pastry is 2$
    {
      _pastryTotalCost = PastriesBought * 2;
    }

    private int _pastryTotalDiscount;
    public int PastryTotalDiscount
    {
      get { return _pastryTotalDiscount; }
      set { _pastryTotalDiscount = value; }
    }

    public void SetPastryDiscount() 
    {
      if (PastriesBought < 4)
      {
        _pastryTotalDiscount = 0;
      }
      else if (PastriesBought >= 4)
      {
        _pastryTotalDiscount = (PastriesBought/4) *2;
      }
      else {
        PastriesBought = 0;
      }
    }

    public int CalculateCost()
    {
      return pastryTotal - PastryTotalDiscount;
    }
  }
}