using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorOrders.Models;
using System.Collections.Generic;
using System;

namespace VendorOrders.Tests
{
  [TestClass]
  public class VendorTests : IDisposable
  {
    public void Dispose()
    {
      Vendor.ClearAll();
    }

    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      Vendor testVendor = new Vendor("xyz bakery");
      Assert.AreEqual(typeof(Vendor), testVendor.GetType());
    }

    [TestMethod]
    public void GetName_ReturnsName_String()
    {
      string name = "xyz bakery";
      Vendor testVendor = new Vendor(name);

      string result = testVendor.Name;

      Assert.AreEqual(name, result);
    }

    [TestMethod]
    public void GetId_ReturnsVendorId_Int()
    {
      string name = "xyz bakery";
      Vendor testVendor = new Vendor(name);

      int result = testVendor.Id;

      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void GetAll_ReturnsAllVendorObjects_VendorList()
    {
      string name01 = "abc bakery";
      string name02 = "xyz cafe";
      Vendor testVendor1 = new Vendor(name01);
      Vendor testVendor2 = new Vendor(name02);
      List<Vendor> newList = new List<Vendor> { testVendor1, testVendor2 };

      List<Vendor> result = Vendor.GetAll();

      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void Find_ReturnsCorrectVendor_Vendor()
    {
      string name01 = "abc bakery";
      string name02 = "xyz cafe";
      Vendor testVendor1 = new Vendor(name01);
      Vendor testVendor2 = new Vendor(name02);

      Vendor result = Vendor.Find(2);

      Assert.AreEqual(testVendor2, result);
    }

    [TestMethod]
    public void AddItem_AssociatesOrderWithVendor_OrderList()
    {
      string item = "bagel";
      int quantity = 5;
      Order testOrder = new Order(item, quantity);
      List<Order> newList = new List<Order> { testOrder };
      string name = "xyz cafe";
      Vendor testVendor = new Vendor(name);
      testVendor.AddOrder(testOrder);

      List<Order> result = testVendor.Orders;

      CollectionAssert.AreEqual(newList, result);
    }

  }
}
