using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RealtorsOffice.Models.RealEstateView
{
    public class NewApartamentsViewModel
    {

        public int Id { get; set; }
        public int CountRooms { get; set; }
        public int NumberRooms { get; set; }
        public decimal Price { get; set; }
        public double Square { get; set; }
        public string Picture { get; set; }
        public int Floor { get; set; }
        public int IdBuilding { get; set; }

    }

    public class NewApartamentsCreateViewModel
    {
        [Required(ErrorMessage = "Please, enter Count Rooms")]
        [Display(Name = "Count Rooms: ")]
        public int CountRooms { get; set; }
        [Required(ErrorMessage = "Please, enter Number Rooms")]
        [Display(Name = "Number Rooms: ")]
        public int NumberRooms { get; set; }
        [Required(ErrorMessage = "Please, enter Price")]
        [Display(Name = "Price: ")]
        public decimal Price { get; set; }
        [Required(ErrorMessage = "Please, enter Square")]
        [Display(Name = "Square: ")]
        public double Square { get; set; }
        [Required(ErrorMessage = "Please, enter Square")]
        [Display(Name = "Square: ")]
        public string Picture { get; set; }
        [Required(ErrorMessage = "Please, enter Floor")]
        [Display(Name = "Floor: ")]
        public int Floor { get; set; }

        public int IdBuilding { get; set; }

    }

    public class NewApartamentsEditViewModel
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
        public decimal Price { get; set; }
        [Required(ErrorMessage = "Please, enter Square")]
        [Display(Name = "Square: ")]
        public double Square { get; set; }
        [Required(ErrorMessage = "Please, enter Square")]
        [Display(Name = "Square: ")]
        public string Picture { get; set; }
        [Required(ErrorMessage = "Please, enter Floor")]
        [Display(Name = "Floor: ")]
        public int Floor { get; set; }

        public int IdBuilding { get; set; }

    }
}