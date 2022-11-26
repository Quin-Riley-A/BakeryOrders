using Microsoft.VisualStudio.TestTools.UnitTesting;
using BakeryOrders.Models;

namespace BakeryOrders.Models
{
  [TestClass]
  public class BreadTests
  {

    [TestMethod]
    public void ClassConstructor_CreatesInstanceOfBread_Bread()
    {
      Bread newLoaves = new Bread(0);
      Assert.AreEqual(typeof(Bread), newLoaves.GetType());
    }
    [TestMethod]
    public void GetQuantity_ReturnsQuantity_Int()
    {
      int breadQty = 2;
      Bread newLoaves = new Bread(breadQty);
      int breadCount = newLoaves.BreadQuantity;
      Assert.AreEqual(breadCount, breadQty);
    }
  }
}