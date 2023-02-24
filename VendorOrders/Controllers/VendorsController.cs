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
  }
}