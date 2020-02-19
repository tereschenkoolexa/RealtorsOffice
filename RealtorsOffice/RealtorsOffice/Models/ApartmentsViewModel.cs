using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;

namespace RealtorsOffice.Models
{
    public class ApartmentsViewModel
    {
        public int NumberRooms { get; set; }
        public decimal Price { get; set; }
        public double Square { get; set; }
        public bool Parking { get; set; }
        public bool Warming { get; set; }
        public bool Repair { get; set; }
        public string Picture { get; set; }
    }

    public class ApartmentsCreateViewModel
    {
        public int NumberRooms { get; set; }
        public decimal Price { get; set; }
        public double Square { get; set; }
        public bool Parking { get; set; }
        public bool Warming { get; set; }
        public bool Repair { get; set; }
        public HttpPostedFileBase Picture { get; set; }
    }


}