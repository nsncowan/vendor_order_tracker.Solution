using System.Collections.Generic;

namespace VendorOrders.Models
{
  public class Order
  {
    private List<Order> _orderList = new List<Order> {};
    public string Item { get; set; }
    public int Id { get; }

    public Order(string item)
    {
      Item = item;
      _orderList.Add(this);
      Id = _orderList.Count;
    }
    
    public static List<Order> GetAll()
    {
      return _orderList;
    }

    public static void ClearAll()
    {
      _orderList.Clear();
    }

    public static Order Find(int searchId)
    {
      return _orderList[searchId-1];
    }

    
  }
}