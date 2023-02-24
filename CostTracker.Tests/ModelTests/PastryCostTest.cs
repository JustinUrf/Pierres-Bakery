using Microsoft.VisualStudio.TestTools.UnitTesting;
using CostTracker.Models;

namespace CostTracker.Tests
{
  [TestClass]
  public class PastryCost 
  {
    [TestMethod]
    public void SetAmountOfPastry_ChecksInstancesOfPastry_Amount() 
    {
      CalculatePastry newPastry = new CalculatePastry();
      newPastry.SetPastryBought(4);
      int amountOfPastry = newPastry.PastriesBought;
      Assert.AreEqual(4, amountOfPastry);
    }

    [TestMethod]
    public void TotalCostBeforeDiscount_MultiplyGivenInstancesOfPastry_TotalAmount()
    {
      CalculatePastry newPastry = new CalculatePastry();
      newPastry.SetPastryBought(4);
      newPastry.MultiplyPastry();
      int result =  newPastry.pastryTotal;
      Assert.AreEqual(8, result);
    }
  }
}
