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
      Assert.AreEqual(4, newBread._breadsBought);
    }
  }
}