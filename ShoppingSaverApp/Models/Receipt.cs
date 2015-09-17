using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShoppingSaverApp.Models
{
    public class Receipt
    {
        public int ReceiptID { get; set; }

        public DateTime Date { get; set; }
        public DateTime Time { get; set; }
        public double Total { get; set; }
        public double Cash { get; set; }
        public double ChangeDue { get; set; }
        public double Subtotal { get; set; }
        public int NumOfItems { get; set; }
        public int ClubCardPoints { get; set; }
        public Double IrishPurchases { get; set; }

        public ICollection<Item> Items { get; set; }
        public ICollection<Shop> Shops { get; set; }

        public void GetReceiptDetails() { }

        public void AddReceipt() { }

    }
}