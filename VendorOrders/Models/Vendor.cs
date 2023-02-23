using System.Collections.Generic;

namespace VendorOrders.Models
{
  public class Vendor
  {
    private List<Vendor> _vendorList = new List<Vendor> {};
    public string Name { get; set; }
    public int Id { get; }
    public List<Order> Orders { get; set; }

    public Vendor(string vendorName)
    {
      Name = vendorName;
      _vendorList.Add(this);
      Id = _vendorList.Count;
      Orders = new List<Order>{};
    }

    public static List<Vendor> GetAll()
    {
      return _vendorList;
    }

    public static Vendor Find(int searchId)
    {
      return _vendorList[searchId-1];
    }

    public void AddOrder(Order order)
    {
      Orders.Add(order);
    }







/*     public static void ClearAll()
    {
      _vendorList.Clear();
    }
 */  
 }
}

