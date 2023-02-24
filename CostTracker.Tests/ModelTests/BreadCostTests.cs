using Microsoft.VisualStudio.TestTools.UnitTesting;
using CostTracker.Models;
using System;

namespace CostTracker.Tests
{
  [TestClass]
  public class BreadCostTests 
  {
    public void BreadCalulation_CountInstancesOfBread_AmountOfBread()
    {
      CalculateBread testAmount = new CalculateBread();
      Assert.AreEqual(1, testAmount);
    }

  }
}
