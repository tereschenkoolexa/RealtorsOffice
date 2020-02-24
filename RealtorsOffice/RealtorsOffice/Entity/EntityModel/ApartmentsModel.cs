using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace RealtorsOffice.Entity.EntityModel
{
    [Table("Apartments")]
    public class ApartmentsModel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int CountRooms { get; set; }
        [Required]
        public int NumberRooms { get; set; }
        [Required]
        public decimal Price { get; set; }
        [Required]
        public double Square { get; set; }
        [Required]
        public bool Parking { get; set; }
        [Required]
        public bool Warming { get; set; }
        [Required]
        public bool Repair { get; set; }

        public string Picture { get; set; }
        [Required]
        public int Floor { get; set; }
        [Required]
        public string StreetName { get; set; }



    }
}