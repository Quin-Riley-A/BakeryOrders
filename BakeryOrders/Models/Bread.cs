using System.Collections.Generic;

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
  }
}