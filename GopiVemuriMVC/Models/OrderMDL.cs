using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GopiVemuriMVC.Models
{
    public class OrderMDL
    {
        public int OrderID {  get; set; }

        public int OrderName { get; set; }

        public int Price { get; set; }

        public string Images { get; set; }

        public int Available { get; set; }
    }
}