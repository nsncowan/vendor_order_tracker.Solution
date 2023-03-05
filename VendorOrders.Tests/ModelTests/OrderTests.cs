using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using VendorOrders.Models;
using System;

namespace VendorOrders.Tests
{
  [TestClass]
  public class OrderTests : IDisposable
  {
    public void Dispose()
    {
      Order.ClearAll();
    }

    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      Order testOrder = new Order("test", 5);
      Assert.AreEqual(typeof(Order), testOrder.GetType());
    }

    [TestMethod]
    public void GetOrderItem_ReturnOrderItem_String()
    {
      string item = "bagel";
      int quantity = 5;
      Order testOrder = new Order(item, quantity);

      string result = testOrder.OrderItem;

      Assert.AreEqual(item, result);
    }

    [TestMethod]
    public void GetOrderPrice_ReturnOrderPrice_Int()
    {
      string item = "bagel";
      int quantity = 7;
      Order testOrder = new Order(item, quantity);
      Assert.AreEqual(testOrder.GetOrderPrice(), 35);
    }

    [TestMethod]
    public void SetOrderItem_SetOrderItem_String()
    {
      string item = "bagel";
      int quantity = 5;
      Order testOrder = new Order(item, quantity);

      string updatedItem = "english muffin";
      testOrder.OrderItem = updatedItem;
      string result = testOrder.OrderItem;

      Assert.AreEqual(updatedItem, result);
    }

    [TestMethod]
    public void GetAll_ReturnsEmptyList_OrderList()
    {
      List<Order> newList = new List<Order> { };

      List<Order> result = Order.GetAll();

      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetAll_ReturnsOrders_OrderList()
    {
      string item1 = "bagel";
      int quant1 = 5;
      string item2 = "english muffin";
      int quant2 = 3;
      Order testOrder1 = new Order(item1, quant1);
      Order testOrder2 = new Order(item2, quant2);
      List<Order> newList = new List<Order> {testOrder1, testOrder2};

      List<Order> result = Order.GetAll();

      CollectionAssert.AreEqual(newList, result);
    }
  }
}
