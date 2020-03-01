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
        public int NumberRooms { get; set; }
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

        [Required(ErrorMessage = "Please, enter Number Rooms")]
        [Display(Name = "Number Rooms: ")]
        public int NumberRooms { get; set; }
        [Required(ErrorMessage = "Please, enter Number Rooms")]
        [Display(Name = "Number Rooms: ")]
        public decimal Price { get; set; }
        [Required(ErrorMessage = "Please, enter Number Rooms")]
        [Display(Name = "Number Rooms: ")]
        public double Square { get; set; }
        [Required(ErrorMessage = "Please, enter Number Rooms")]
        [Display(Name = "Number Rooms: ")]
        public bool Parking { get; set; }
        [Required(ErrorMessage = "Please, enter Number Rooms")]
        [Display(Name = "Number Rooms: ")]
        public bool Warming { get; set; }
        [Required(ErrorMessage = "Please, enter Number Rooms")]
        [Display(Name = "Number Rooms: ")]
        public bool Repair { get; set; }
        public string Picture { get; set; }
        public string StreetName { get; set; }
        public int Floors { get; set; }
        public string City { get; set; }

    }

}