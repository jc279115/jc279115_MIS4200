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
        public string userComment { get; set; }
        public DateTime visitDate { get; set; }
        
        public int userID { get; set; }
        public virtual User User { get; set; }
        
        public int placeID { get; set; }
        public virtual Place Place { get; set; }
    }
}