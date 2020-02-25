using RealtorsOffice.Entity.EntityModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace RealtorsOffice.Models.Communication
{
    [Table("tblRealtorNewApartment")]
    public class RealtorNewApartment
    {
        [Key, ForeignKey("RealtorOf"), Column(Order = 1)]
        public string IdRealtor { get; set; }
        public virtual MoreInfoRealtor RealtorOf { get; set; }

        [Key, ForeignKey("NewApartmentsOf"), Column(Order = 2)]
        public int IdHouse { get; set; }
        public virtual NewApartmentsModel NewApartmentsOf { get; set; }
    }
}