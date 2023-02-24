using Microsoft.VisualStudio.TestTools.UnitTesting;
using CostTracker.Models;

namespace CostTracker.Tests
{
  [TestClass]
  public class BreadCostTest
  {
    [TestMethod]
    public void BreadCostConstructor_ChecksInstancesOfBread_Amount()
    {
      CalculateBread newBread = new CalculateBread();
      newBread.SetBreadBought(4);
      Assert.AreEqual(4, newBread.BreadsBought);
    }

    [TestMethod]
    public void TotalCost_MultiplyGivenInstancesOfBread_TotalAmount()
    {
      CalculateBread newBread = new CalculateBread();
      newBread.SetBreadBought(5);
      newBread.MultiplyBread();
      Assert.AreEqual(25, newBread.TotalCost);
    }

    [TestMethod]
    public void ApplyDiscount_TakeTotalCostAndApplyDiscount_DiscountAmount()
    {
      CalculateBread newBread = new CalculateBread();
      newBread.SetBreadBought(4);
      newBread.MultiplyBread();
      newBread.SetDiscount();
      Assert.AreEqual(5, newBread.TotalDiscount);

    }
  }
}