using RealtorsOffice.Models.Communication;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace RealtorsOffice.Models
{
    public class MoreInfoRealtor
    {

        [Key, ForeignKey("RealtorOf")]
        public string Id { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
        [Required]
        public string NameCompany { get; set; }

        public virtual ApplicationUser RealtorOf { get; set; }

        public virtual ICollection<RealtorApartment> RealtorApartments { get; set; }
        public virtual ICollection<RealtorHouse> RealtorHouses { get; set; }
        public virtual ICollection<RealtorNewApartment> RealtorNewApartments { get; set; }
        public virtual ICollection<RealtorNewBuilding> RealtorNewBuildings { get; set; }
    }
}