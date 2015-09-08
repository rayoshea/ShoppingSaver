using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShoppingSaverApp.Models
{
    public class Item
    {
        public string ItemID { get; set; }

        public int productCode {get; set;}
        public double price { get; set; }
        public string category { get; set; }
        public double size { get; set; }
        public bool isIrish { get; set; }
        public bool isOnSale { get; set; }

        public Receipt Receipt { get; set; }

        public void GetItem() { }
    }
}