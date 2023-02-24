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

  }
}
