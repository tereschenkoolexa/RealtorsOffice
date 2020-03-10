using RealtorsOffice.Models.Communication;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace RealtorsOffice.Entity.EntityModel
{
    [Table("tblNewApartmentsModel")]
    public class NewApartmentsModel

    {
        [Key, ForeignKey("RealtorNewApartmentOf")]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        [Required]
        public int CountRooms { get; set; }
        [Required]
        public decimal Price { get; set; }
        [Required]
        public double Square { get; set; }
        [Required]
        public string Picture { get; set; }
        [Required]
        public int Floor { get; set; }

        [ForeignKey("NewBuildingOf")]
        public int IdBuilding { get; set; }
        public virtual NewBuildingModel NewBuildingOf { get; set; }

        public virtual ICollection<RealtorNewApartment> RealtorNewApartmentOf { get; set; }
    }
}