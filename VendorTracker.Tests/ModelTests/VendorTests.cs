using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using VendorTracker.Models;
using System;

namespace VendorTracker.Tests
{
  [TestClass]
  public class VendorTests : IDisposable
  {
    public void Dispose()
    {
      Vendor.ClearAll();
    }

    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfOrder_Order()
    {
      Vendor newVendor = new Vendor("test", "test");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }
    [TestMethod]
    public void GetAll_ReturnsEmptyList_VendorList()
    {
      List<Vendor> newVendor = new List<Vendor> { };

      List<Vendor> result = Vendor.GetAll();

      CollectionAssert.AreEqual(newVendor, result);
    }
    [TestMethod]
    public void AddOrder_AssociatesOrdrWithVendor_OrderList()
    {
      string description = "test";
      string title = "test";
      string price = "test";
      string date = "test";
      Order newOrder = new Order(title, description, price, date);
      List<Order> newList = new List<Order> { newOrder };
      string name = "Suzy";
      string venDescription = "Grocery";
      Vendor newVendor = new Vendor(name, venDescription);
      newVendor.AddOrder(newOrder);

      List<Order> result = newVendor.Orders;

      CollectionAssert.AreEqual(newList, result);
    }
  }  
}