using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RealtorsOffice.Entity.EntityModel
{
    public class ApartmentsModel
    {
        public int NumberRooms { get; set; }
        public decimal Price { get; set; }
        public double Square { get; set; }
        public bool Parking { get; set; }
        public bool Warming { get; set; }
        public bool Repair { get; set; }
        public string Picture { get; set; }
        public string StreetName { get; set; }
    }
}