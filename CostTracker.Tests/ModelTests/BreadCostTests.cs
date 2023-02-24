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
      int testTotalCost = newBread.TotalCost;
      Assert.AreEqual(25, testTotalCost);
    }

    [TestMethod]
    public void ApplyDiscount_TakeNumberOfBreadAndGetDiscount_DiscountAmount()
    {
      CalculateBread newBread = new CalculateBread();
      newBread.SetBreadBought(4);
      newBread.MultiplyBread();
      newBread.SetDiscount();
      int result = newBread.TotalDiscount;
      Assert.AreEqual(5, result);
    }

    [TestMethod]
    public void CostOfBread_TakeTotalCostAndDiscountCalculateFinalAmount_WhatCustomerPays() 
    {
      CalculateBread newBread = new CalculateBread();
      newBread.SetBreadBought(4);
      newBread.MultiplyBread();
      newBread.SetDiscount();
      int result = newBread.CalcualateCost();
      Assert.AreEqual(15, result);
    }
  }
}