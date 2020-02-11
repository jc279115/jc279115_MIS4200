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
        public string restName { get; set; }
        public string address { get; set; }
        public string phoneNUmber { get; set; }
        public ICollection<Review> Review { get; set; }
    }
}