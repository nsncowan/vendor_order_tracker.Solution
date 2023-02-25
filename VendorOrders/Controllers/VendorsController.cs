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

  }
}