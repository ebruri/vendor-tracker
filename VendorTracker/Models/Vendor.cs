using System.Collections.Generic;

namespace VendorTracker.Models
{
  public class Vendor
  {
    public string name { get; set; }
    public string description { get; set; }
    private static List<Order> _instances = new List<Order> {};
  }
}  