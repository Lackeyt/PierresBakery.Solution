using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using PierresBakery.Models;
using System;

namespace PierresBakery.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void BreadConstructor_CreatesInstanceOfBread_Bread()
    {
      Bread newBreadOrder = new Bread();
      Assert.AreEqual(typeof(Bread), newBreadOrder.GetType());
    }
  }
}