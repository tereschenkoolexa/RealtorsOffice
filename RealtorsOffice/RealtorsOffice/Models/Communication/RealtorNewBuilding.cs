using RealtorsOffice.Entity.EntityModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace RealtorsOffice.Models.Communication
{
    public class RealtorNewBuilding
    {
        [Key, ForeignKey("RealtorOf"), Column(Order = 1)]
        public int IdRealtor { get; set; }
        public virtual MoreInfoRealtor RealtorOf { get; set; }

        [Key, ForeignKey("NewBuildingOf"), Column(Order = 4)]
        public int IdNewBuilding { get; set; }
        public virtual NewBuildingModel NewBuildingOf { get; set; }
    }
}