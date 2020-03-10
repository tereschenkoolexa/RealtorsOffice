using RealtorsOffice.Models.Communication;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace RealtorsOffice.Entity.EntityModel
{
    [Table("NewBuildings")]
    public class NewBuildingModel
    {
        [Required]
        public string Name { get; set; }
        [Key, ForeignKey("RealtorNewBuildingOf")]
        public int Id { get; set; }
        [Required]
        public string StreetName { get; set; }
        [Required]
        public string DistrictName { get; set; }
        [Required]
        public string Picture { get; set; }
        [Required]
        public int Floors { get; set; }
        [Required]
        public bool Parking { get; set; }
        [Required]
        public bool Warming { get; set; }
        [Required]
        public bool ConstructionStatus { get; set; }
        [Required]
        public DataType DateOfConstructed { get; set; }
        [Required]
        public string City { get; set; }

        public virtual ICollection<ApartmentsModel> Apartments { get; set; }
        public virtual ICollection<RealtorNewBuilding> RealtorNewBuildingOf { get; set; }
    }
}