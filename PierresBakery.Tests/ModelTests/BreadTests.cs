using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;

namespace PierresBakery.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void BreadConstructor_CreatesInstanceOfBread_Bread()
    {
      Bread newBreadOrder = new Bread("5");
      Assert.AreEqual(typeof(Bread), newBreadOrder.GetType());
    }

    [TestMethod]
    public void IsBreadOrderValid_ReturnsTrueForValidIntegerBreadOrder_True()
    {
      Bread newBreadOrder = new Bread("5");
      Assert.AreEqual(true, newBreadOrder.IsBreadOrderValid());
    }

    [TestMethod]
    public void IsBreadOrderValid_ReturnsFalseForInvalidIntegerBreadOrder_False()
    {
      Bread newBreadOrder = new Bread("Five");
      Assert.AreEqual(false, newBreadOrder.IsBreadOrderValid());
    }

    [TestMethod]
    public void BreadCostCalc_EachBreadCosts5_10()
    {
      Bread newBreadOrder = new Bread("2");
      newBreadOrder.IsBreadOrderValid();
      newBreadOrder.BreadCostCalc();
      Assert.AreEqual(10, newBreadOrder.BreadCost);
    }

    [TestMethod]
    public void BreadCostCalc_EveryThirdBreadCosts0_10()
    {
      Bread newBreadOrder = new Bread("3");
      newBreadOrder.IsBreadOrderValid();
      newBreadOrder.BreadCostCalc();
      Assert.AreEqual(10, newBreadOrder.BreadCost);
    }

    [TestMethod]
    public void BreadCostCalc_Every21stBreadReduceCostBy10_60()
    {
      Bread newBreadOrder = new Bread("21");
      newBreadOrder.IsBreadOrderValid();
      newBreadOrder.BreadCostCalc();
      Assert.AreEqual(60, newBreadOrder.BreadCost);
    }
  }
}