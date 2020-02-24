using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace jc279115_MIS4200.Models
{
    public class Review
    {
        public int reviewID { get; set; }

        [Display(Name = "Comments")]
        [Required(ErrorMessage = "Please enter your comments")]
        [StringLength(999)]
        public string userComment { get; set; }

        [Display(Name = "Visit Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode =true)]
        public DateTime visitDate { get; set; }
        
        [Display(Name ="User's Name")]
        public int userID { get; set; }
        public virtual User User { get; set; }

        [Display(Name = "Resturant Name")]
        public int placeID { get; set; }
        public virtual Place Place { get; set; }
    }
}