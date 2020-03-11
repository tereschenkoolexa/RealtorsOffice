using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RealtorsOffice.Models.RealEstateView
{
    public class NewBuildingViewModel
    {

        public int Id { get; set; }
        public string StreetName { get; set; }
        public string Picture { get; set; }
        public string DistrictName { get; set; }
        public int Floors { get; set; }
        public bool Parking { get; set; }
        public bool Warming { get; set; }
        public bool ConstructionStatus { get; set; }
        public DataType DateOfConstructed { get; set; }
        public string City { get; set; }

    }

    public class NewBuildingCreateViewModel
    {

        public int Id { get; set; }

        [Required(ErrorMessage = "Please, enter Street Name")]
        [Display(Name = "Street Name: ")]
        public string StreetName { get; set; }
        [Required(ErrorMessage = "Please, enter District Rooms")]
        [Display(Name = "District Rooms: ")]
        public string DistrictName { get; set; }
        [Required(ErrorMessage = "Please, enter Picture")]
        [Display(Name = "Picture: ")]
        public string Picture { get; set; }
        [Required(ErrorMessage = "Please, enter Floors")]
        [Display(Name = "Floors: ")]
        public int Floors { get; set; }
        [Required(ErrorMessage = "Please, enter Parking")]
        [Display(Name = "Parking: ")]
        public bool Parking { get; set; }
        [Required(ErrorMessage = "Please, enter Warming")]
        [Display(Name = "Warming: ")]
        public bool Warming { get; set; }
        [Required(ErrorMessage = "Please, enter Construction Status")]
        [Display(Name = "Construction Status: ")]
        public bool ConstructionStatus { get; set; }
        [Required(ErrorMessage = "Please, enter DateOfConstructed")]
        [Display(Name = "DateOfConstructed: ")]
        public DataType DateOfConstructed { get; set; }
        [Required(ErrorMessage = "Please, enter City")]
        [Display(Name = "City: ")]
        public string City { get; set; }

    }

    public class NewBuildingEditViewModel
    {

        public int Id { get; set; }
        [Required(ErrorMessage = "Please, enter Street Name")]
        [Display(Name = "Street Name: ")]
        public string StreetName { get; set; }
        [Required(ErrorMessage = "Please, enter District Rooms")]
        [Display(Name = "District Rooms: ")]
        public string DistrictName { get; set; }
        [Required(ErrorMessage = "Please, enter Picture")]
        [Display(Name = "Picture: ")]
        public string Picture { get; set; }
        [Required(ErrorMessage = "Please, enter Floors")]
        [Display(Name = "Floors: ")]
        public int Floors { get; set; }
        [Required(ErrorMessage = "Please, enter Parking")]
        [Display(Name = "Parking: ")]
        public bool Parking { get; set; }
        [Required(ErrorMessage = "Please, enter Warming")]
        [Display(Name = "Warming: ")]
        public bool Warming { get; set; }
        [Required(ErrorMessage = "Please, enter Construction Status")]
        [Display(Name = "Construction Status: ")]
        public bool ConstructionStatus { get; set; }
        [Required(ErrorMessage = "Please, enter DateOfConstructed")]
        [Display(Name = "DateOfConstructed: ")]
        public DataType DateOfConstructed { get; set; }
        [Required(ErrorMessage = "Please, enter City")]
        [Display(Name = "City: ")]
        public string City { get; set; }

    }
}