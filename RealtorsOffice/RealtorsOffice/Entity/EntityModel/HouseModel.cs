using RealtorsOffice.Models.Communication;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace RealtorsOffice.Entity.EntityModel
{
    [Table("Houses")]
    public class HouseModel
    {
        [Key, ForeignKey("RealtorHousesOf")]
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
        public bool Parking { get; set; }
        [Required]
        public bool Warming { get; set; }
        [Required]
        public bool Repair { get; set; }
        [Required]
        public string Picture { get; set; }
        [Required]
        public string DistrictName { get; set; }
        [Required]
        public string StreetName { get; set; }
        [Required]
        public int Floors { get; set; }
        [Required]
        public string City { get; set; }

        public virtual ICollection<RealtorHouse> RealtorHousesOf { get; set; }
    }
}