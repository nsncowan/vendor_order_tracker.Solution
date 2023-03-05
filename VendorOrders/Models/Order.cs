using System.Collections.Generic;

namespace VendorOrders.Models
{
  public class Order
  {
    private static List<Order> _orderList = new List<Order> {};
    public string OrderItem { get; set; }
    public int ItemQuantity { get; set; }
    public int Id { get; }
    public static int CostPerItem = 5;
    public int OrderPrice { get; set; }

    public Order(string item, int itemQuantity)
    {
      OrderItem = item;
      ItemQuantity = itemQuantity;
      _orderList.Add(this);
      Id = _orderList.Count;
    }
    
    public static List<Order> GetAll()
    {
      return _orderList;
    }

    public int GetOrderPrice()
    {
      OrderPrice = CostPerItem * ItemQuantity;
      return OrderPrice;
    }

    public static Order Find(int searchId)
    {
      return _orderList[searchId-1];
    }

    public static void ClearAll()
    {
      _orderList.Clear();
    }
  }
}