using RealtorsOffice.Entity.EntityModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace RealtorsOffice.Models.Communication
{
    [Table("tblRealtorNewBuilding")]
    public class RealtorNewBuilding
    {
        [Key, ForeignKey("RealtorOf"), Column(Order = 1)]
        public string RealtorId { get; set; }
        public virtual MoreInfoRealtor RealtorOf { get; set; }

        [Key, ForeignKey("NewBuildingOf"), Column(Order = 2)]
        public int NewBuildingId { get; set; }
        public virtual NewBuildingModel NewBuildingOf { get; set; }
    }
}