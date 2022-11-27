namespace BakeryOrders.Models
{
  public class Bread
  {
    public int BreadQuantity {get; set; }
    public double Price {get; set; }
    public Bread(int quantity)
    {
      BreadQuantity = quantity;
    }
    public void getPrice()
    {
      Price = ((this.BreadQuantity/3) * 10) + (this.BreadQuantity%3)*5;
    }
  }
}