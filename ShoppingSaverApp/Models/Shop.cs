using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShoppingSaverApp.Models
{
    public class Shop
    {
        public string ShopID { get; set; }

        public string Name { get; set; }
        public string Location { get; set; }
        public DateTime OpeningTimes { get; set; }
        public string WebAddress { get; set; }
        public int TelephoneNum { get; set; }
        public string Assistant { get; set; }
        public string Manager { get; set; }

        public Receipt Receipt { get; set; }
        public Person Person { get; set; }
        

        public void GetShopDetails() { }
    }
}