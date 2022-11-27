namespace BakeryOrders.Models
{
  public class Pastry
  {
    public int PastryQuantity {get; set; }
    public int Price;
    public Pastry(int pastryQty)
    {
      PastryQuantity = pastryQty;
    }
    public void getPrice()
    {
      this.Price = ((this.PastryQuantity/3) * 5) + (this.PastryQuantity%3)*2;
    }
  }
}