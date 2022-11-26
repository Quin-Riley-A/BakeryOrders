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
      Bread newLoaves = new Bread();
      Assert.AreEqual(typeof(Bread), newLoaves.GetType());
    }
  }
}