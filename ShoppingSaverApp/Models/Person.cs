using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShoppingSaverApp.Models
{
    public class Person
    {
        public int PersonID { get; set; }

        public string UserName { get; set; }
        public string Email { get; set;}

        public ICollection<Shop> Shops { get; set; }

        public void getPersonDetails() { }

    }
}