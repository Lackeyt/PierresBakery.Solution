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
      Bread newBreadOrder = new Bread("test", "5");
      Assert.AreEqual(typeof(Bread), newBreadOrder.GetType());
    }

    [TestMethod]
    public void IsBreadTypeValid_IsWhiteBreadValid_True()
    {
      Bread newBreadOrder = new Bread("white", "test");
      Assert.AreEqual(true, newBreadOrder.isBreadTypeValid());
    }

    [TestMethod]
    public void IsBreadTypeValid_IsSourdoughBreadValid_True()
    {
      Bread newBreadOrder = new Bread("sourdough", "test");
      Assert.AreEqual(true, newBreadOrder.isBreadTypeValid());
    }

    [TestMethod]
    public void IsBreadTypeValid_IsBaguetteValid_True()
    {
      Bread newBreadOrder = new Bread("baguette", "test");
      Assert.AreEqual(true, newBreadOrder.isBreadTypeValid());
    }

    [TestMethod]
    public void IsBreadTypeValid_IsItalianBreadValid_True()
    {
      Bread newBreadOrder = new Bread("italian", "test");
      Assert.AreEqual(true, newBreadOrder.isBreadTypeValid());
    }

    [TestMethod]
    public void IsBreadTypeValid_IsBreadTypeInvalid_False()
    {
      Bread newBreadOrder = new Bread("FLATBREAD", "test");
      Assert.AreEqual(false, newBreadOrder.isBreadTypeValid());
    }

    [TestMethod]
    public void IsBreadOrderValid_ReturnsTrueForValidIntegerBreadOrder_True()
    {
      Bread newBreadOrder = new Bread("test", "5");
      Assert.AreEqual(true, newBreadOrder.IsBreadOrderNumberValid());
    }

    [TestMethod]
    public void IsBreadOrderValid_ReturnsFalseForInvalidIntegerBreadOrder_False()
    {
      Bread newBreadOrder = new Bread("test", "Five");
      Assert.AreEqual(false, newBreadOrder.IsBreadOrderNumberValid());
    }

    [TestMethod]
    public void BreadCostCalc_EachWhiteBreadCosts5_10()
    {
      Bread newBreadOrder = new Bread("white", "2");
      newBreadOrder.IsBreadOrderNumberValid();
      newBreadOrder.BreadCostCalc();
      Assert.AreEqual(10, newBreadOrder.BreadCost);
    }

    [TestMethod]
    public void BreadCostCalc_EachSourdoughBreadCosts8_16()
    {
      Bread newBreadOrder = new Bread("sourdough", "2");
      newBreadOrder.IsBreadOrderNumberValid();
      newBreadOrder.BreadCostCalc();
      Assert.AreEqual(16, newBreadOrder.BreadCost);
    }

    [TestMethod]
    public void BreadCostCalc_EveryThirdBreadCosts0_10()
    {
      Bread newBreadOrder = new Bread("white", "3");
      newBreadOrder.IsBreadOrderNumberValid();
      newBreadOrder.BreadCostCalc();
      Assert.AreEqual(10, newBreadOrder.BreadCost);
    }

    [TestMethod]
    public void BreadCostCalc_Every21stBreadReduceCostBy2xBreadTypeCost_60()
    {
      Bread newBreadOrder = new Bread("white", "21");
      newBreadOrder.IsBreadOrderNumberValid();
      newBreadOrder.BreadCostCalc();
      Assert.AreEqual(60, newBreadOrder.BreadCost);
    }
  }
}