using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace RealtorsOffice.Entity.EntityModel
{
    public class NewApartmentsModel

    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("NewBuildingOf")]
        public int IdBuilding { get; set; }
        public virtual NewBuildingModel NewBuildingOf { get; set; }
        [Required]
        public int CountRooms { get; set; }
        [Required]
        public int NumberRooms { get; set; }
        [Required]
        public decimal Price { get; set; }
        [Required]
        public double Square { get; set; }
        [Required]
        public string Picture { get; set; }
        [Required]
        public int Floor { get; set; }
    }
}