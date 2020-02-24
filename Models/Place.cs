using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace jc279115_MIS4200.Models
{
    public class Place
    {
        public int placeID { get; set; }

        [Display(Name = "Resturant Name")]
        [Required(ErrorMessage ="Resturant name is required")]
        [StringLength(99)]
        public string restName { get; set; }

        [Display(Name = "Street Address")]
        [Required(ErrorMessage = "Street Address is required")]
        [StringLength(99)]
        public string streetAddress { get; set; }

        [Display(Name = "Zip Code")]
        [Required(ErrorMessage = "Zip code is required")]
        [DataType(DataType.PostalCode)]
        public int zipCode { get; set; }

        [Display(Name = "State")]
        [StringLength(2, MinimumLength =2, ErrorMessage ="State must be two characters")]
        public string state { get; set; }

        [Display(Name = "Resturant Phone Number")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^(\(\d{3}\) |\d{3}-)\d{3}-\d{4}$")]
        public string phoneNUmber { get; set; }

        public ICollection<Review> Review { get; set; }
    }
}