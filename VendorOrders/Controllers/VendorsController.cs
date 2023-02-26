using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using VendorOrders.Models;

namespace VendorOrders.Controllers
{
  public class VendorsController : Controller
  {
    [HttpGet("/vendors")]
    public ActionResult Index()
    {
      List<Vendor> vendorsList = Vendor.GetAll();
      return View();
    }

    [HttpGet("/vendors/new")]
    public ActionResult New()
    {
      return View();
    }

// this one creates and new vendor.
    [HttpPost("/vendors")]
    public ActionResult Create(string vendorName)
    {
      Vendor newVendor = new Vendor(vendorName);
      return RedirectToAction("Index");
    } 

    // This one creates new Orders for a vendor, not new vendors:
    [HttpPost("/vendors/{vendorId}/orders")]
    public ActionResult Create(int vendorId, string item, string itemQuantity)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Vendor targetVendor = Vendor.Find(vendorId);
      Order newOrder = new Order(vendorId, item, itemQuantity);
      targetVendor.AddOrder(newOrder);
      List<Order> vendorOrders = targetVendor.Orders;
      model.Add("orders", vendorOrders);
      model.Add("vendor", targetVendor);
      return View("Show", model);
    }

  }
}