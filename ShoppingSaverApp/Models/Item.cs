using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShoppingSaverApp.Models
{
    public class Item
    {
        public string ItemID { get; set; }

        public int ProductCode { get; set; }
        public double Price { get; set; }
        public string Category { get; set; }
        public double Size { get; set; }
        public bool IsIrish { get; set; }
        public bool IsOnSale { get; set; }

        public Receipt Receipt { get; set; }

        public void GetItem() { }
    }
}