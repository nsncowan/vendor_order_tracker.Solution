using System.Collections.Generic;

namespace VendorOrders.Models
{
  public class Order
  {
    private static List<Order> _orderList = new List<Order> {};
    public string OrderItem { get; set; }
    public string ItemQuantity { get; set; }
    public static int CostPerItem = 5;
    public int OrderPrice { get; set; }

    // if i wanted to have multiple items each with their own price, would i set multiple static prices as fields here? then maybe I could have branching logic in  GetOrderPrice().

    public Order(string item, string itemQuantity)
    {
      OrderItem = item;
      ItemQuantity = itemQuantity;
      _orderList.Add(this);
    }
    
    public static List<Order> GetAll()
    {
      return _orderList;
    }

    public int GetOrderPrice()
    {
      OrderPrice = CostPerItem * int.Parse(ItemQuantity);
      return OrderPrice;
    }

    public static void ClearAll()
    {
      _orderList.Clear();
    }
  }
}