using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RealtorsOffice.Models.RealEstateView
{
    public class HouseViewModel
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public int CountRooms { get; set; }
        public string DistrictName { get; set; }
        public decimal Price { get; set; }
        public double Square { get; set; }
        public bool Parking { get; set; }
        public bool Warming { get; set; }
        public bool Repair { get; set; }
        public string Picture { get; set; }
        public string StreetName { get; set; }
        public int Floors { get; set; }
        public string City { get; set; }

    }

    public class HouseCreateViewModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Please, enter Name")]
        [Display(Name = "Name: ")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please, enter Count Rooms")]
        [Display(Name = "Count Rooms: ")]
        public int CountRooms { get; set; }
        [Required(ErrorMessage = "Please, enter District Rooms")]
        [Display(Name = "District Rooms: ")]
        public string DistrictName { get; set; }

        [Required(ErrorMessage = "Please, enter Price")]
        [Display(Name = "Price: ")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "Please, enter Square")]
        [Display(Name = "Square: ")]
        public double Square { get; set; }

        [Required(ErrorMessage = "Please, enter Parking")]
        [Display(Name = "Parking: ")]
        public bool Parking { get; set; }

        [Required(ErrorMessage = "Please, enter Warming")]
        [Display(Name = "Warming: ")]
        public bool Warming { get; set; }

        [Required(ErrorMessage = "Please, enter Repair")]
        [Display(Name = "Repair: ")]
        public bool Repair { get; set; }

        [Required(ErrorMessage = "Please, enter Picture")]
        [Display(Name = "Picture: ")]
        public string Picture { get; set; }

        [Required(ErrorMessage = "Please, enter Street Name")]
        [Display(Name = "Street Name: ")]
        public string StreetName { get; set; }

        [Required(ErrorMessage = "Please, enter Floors")]
        [Display(Name = "Floors: ")]
        public int Floors { get; set; }

        [Required(ErrorMessage = "Please, enter City")]
        [Display(Name = "City: ")]
        public string City { get; set; }

    }

    public class HouseEditViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please, enter Name")]
        [Display(Name = "Name: ")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please, enter Count Rooms")]
        [Display(Name = "Count Rooms: ")]
        public int CountRooms { get; set; }
        [Required(ErrorMessage = "Please, enter District Rooms")]
        [Display(Name = "District Rooms: ")]
        public string DistrictName { get; set; }

        [Required(ErrorMessage = "Please, enter Price")]
        [Display(Name = "Price: ")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "Please, enter Square")]
        [Display(Name = "Square: ")]
        public double Square { get; set; }

        [Required(ErrorMessage = "Please, enter Parking")]
        [Display(Name = "Parking: ")]
        public bool Parking { get; set; }

        [Required(ErrorMessage = "Please, enter Warming")]
        [Display(Name = "Warming: ")]
        public bool Warming { get; set; }

        [Required(ErrorMessage = "Please, enter Repair")]
        [Display(Name = "Repair: ")]
        public bool Repair { get; set; }

        [Required(ErrorMessage = "Please, enter Picture")]
        [Display(Name = "Picture: ")]
        public string Picture { get; set; }

        [Required(ErrorMessage = "Please, enter Street Name")]
        [Display(Name = "Street Name: ")]
        public string StreetName { get; set; }

        [Required(ErrorMessage = "Please, enter Floors")]
        [Display(Name = "Floors: ")]
        public int Floors { get; set; }

        [Required(ErrorMessage = "Please, enter City")]
        [Display(Name = "City: ")]
        public string City { get; set; }
    }

}