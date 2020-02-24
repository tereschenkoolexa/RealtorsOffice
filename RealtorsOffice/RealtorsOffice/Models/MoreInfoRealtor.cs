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
        public List<string> PhoneNumber { get; set; }
        [Required]
        public string NameCompany { get; set; }

        public virtual ApplicationUser RealtorOf { get; set; }

    }
}