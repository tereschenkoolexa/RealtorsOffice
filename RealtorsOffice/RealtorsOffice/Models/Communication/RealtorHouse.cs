using RealtorsOffice.Entity.EntityModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace RealtorsOffice.Models.Communication
{
    public class RealtorHouse
    {
        [Key, ForeignKey("RealtorOf"), Column(Order = 1)]
        public int IdRealtor { get; set; }
        public virtual MoreInfoRealtor RealtorOf { get; set; }

        [Key, ForeignKey("HouseOf"), Column(Order = 2)]
        public int IdHouse { get; set; }
        public virtual HouseModel HouseOf { get; set; }

    }
}