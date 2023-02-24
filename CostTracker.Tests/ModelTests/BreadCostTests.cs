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
      Assert.AreEqual(1, 0);
    }
  }
}