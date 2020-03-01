using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;
using System.Linq;
using System.Web;

namespace RealtorsOffice.Models
{
    public class ApartmentsViewModel
    {

        public int Id { get; set; }
        public int CountRooms { get; set; }
        public int NumberRooms { get; set; }
        public decimal Price { get; set; }
        public double Square { get; set; }
        public bool Parking { get; set; }
        public bool Warming { get; set; }
        public bool Repair { get; set; }
        public string Picture { get; set; }
        public int Floor { get; set; }
        public string StreetName { get; set; }
        public string City { get; set; }

    }

    public class ApartmentsCreateViewModel
    {

        [Required(ErrorMessage = "Please, enter Count Rooms")]
        [Display(Name = "Count Rooms: ")]
        public int CountRooms { get; set; }

        [Required(ErrorMessage = "Please, enter Number Rooms")]
        [Display(Name = "Number Rooms: ")]
        public int NumberRooms { get; set; }

        [Required(ErrorMessage = "Please, enter Price")]
        [Display(Name = "Price: ")]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
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

        [Required(ErrorMessage = "Please, enter Floor")]
        [Display(Name = "Floor: ")]
        public int Floor { get; set; }

        [Required(ErrorMessage = "Please, enter Street Name")]
        [Display(Name = "Street Name: ")]
        public string StreetName { get; set; }

        [Required(ErrorMessage = "Please, enter City")]
        [Display(Name = "City: ")]
        public string City { get; set; }
    }

    public class ApartmentsEditViewModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Please, enter Count Rooms")]
        [Display(Name = "Count Rooms: ")]
        public int CountRooms { get; set; }

        [Required(ErrorMessage = "Please, enter Number Rooms")]
        [Display(Name = "Number Rooms: ")]
        public int NumberRooms { get; set; }

        [Required(ErrorMessage = "Please, enter Price")]
        [Display(Name = "Price: ")]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
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

        [Required(ErrorMessage = "Please, enter Floor")]
        [Display(Name = "Floor: ")]
        public int Floor { get; set; }

        [Required(ErrorMessage = "Please, enter Street Name")]
        [Display(Name = "Street Name: ")]
        public string StreetName { get; set; }

        [Required(ErrorMessage = "Please, enter City")]
        [Display(Name = "City: ")]
        public string City { get; set; }
    }

}