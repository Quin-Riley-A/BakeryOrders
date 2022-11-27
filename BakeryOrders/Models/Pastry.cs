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

  }
}