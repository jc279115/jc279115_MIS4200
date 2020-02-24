using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace jc279115_MIS4200.Models
{
    public class User
    {
        public int userID { get; set; }
        [Display(Name = "Full Name")]
        [Required(ErrorMessage = "User full name is required")]
        [StringLength(20)]
        public string fullName { get; set; }

        [Display(Name = "Username")]
        [Required(ErrorMessage = "Username is required")]
        [StringLength(20)]
        public string userName { get; set; }

        [Display(Name = "Password")]
        [Required(ErrorMessage = "Password is required")]
        [StringLength(99)]
        public string passWord { get; set; }

        [Display(Name = "Email")]
        [Required(ErrorMessage = "Email is required")]
        [DataType(DataType.EmailAddress)]
        public string email { get; set; }

        [Display(Name = "User Phone Number")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^(\(\d{3}\) |\d{3}-)\d{3}-\d{4}$", ErrorMessage = "Phone number must be in the format (xxx) xxx-xxxx or xxx-xxx-xxxx")]
        public string phoneNumber { get; set; }
        public ICollection<Review> Review { get; set; }
        
    }
}