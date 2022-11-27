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
      Assert.AreEqual(1, newDoughs.PastryQuantity);
    }
    [TestMethod]
    public void GetPrice_AssignsPriceProperty_Int()
    {
      Pastry newDoughs = new Pastry(1);
      newDoughs.getPrice();
      Assert.AreEqual(2, newDoughs.Price);
    }
    [TestMethod]
    public void GetPrice_AssignsPriceWithDiscount_Int()
    {
      Pastry newDoughs = new Pastry(7);
      newDoughs.getPrice();
      Assert.AreEqual(12, newDoughs.Price);
    }
  }
}