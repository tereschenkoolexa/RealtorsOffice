using RealtorsOffice.Entity.EntityModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace RealtorsOffice.Models
{
    [Table("tblRealtorApartment")]
    public class RealtorApartment
    {

        [Key, ForeignKey("RealtorOf"), Column(Order = 0)]
        public string IdRealtor { get; set; }
        public virtual MoreInfoRealtor RealtorOf { get; set; }

        [Key, ForeignKey("ApartmentOf"), Column(Order = 1)]
        public int IdApartment { get; set; }
        public virtual ApartmentsModel ApartmentOf { get; set; }


    }
}