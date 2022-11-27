using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace BakeryOrders.Models
{
  [TestClass]
  public class PastryTests
  {
    [TestMethod]
    public void ClassConstructor_CreatesInstanceOfPastry_Pastry()
    {
      Pastry newDoughs = new Pastry();
      Assert.AreEqual(typeof(Pastry), newDoughs.GetType());
    }
  }
}