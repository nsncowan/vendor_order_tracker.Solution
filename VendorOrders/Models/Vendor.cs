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

    public static void ClearAll()
    {
      _vendorList.Clear();
    }
  }
}

