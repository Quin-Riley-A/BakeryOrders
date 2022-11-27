using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace BakeryOrders.Models
{
  [TestClass]
  public class PastryTests
  {
    [TestMethod]
    public void ClassConstructor_CreatesInstanceOfPastry_Pastry()
    {
      Pastry newDoughs = new Pastry(0);
      Assert.AreEqual(typeof(Pastry), newDoughs.GetType());
    }
    [TestMethod]
    public void GetQuantity_ReturnsQuantity_Int()
    {
      int pastryQty = 1;
      Pastry newDoughs = new Pastry(pastryQty);
      Assert.AreEqual(newDoughs.PastryQuantity, 1);
    }
  }
}