using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace jc279115_MIS4200.Models
{
    public class Places
    {
        public int placeID { get; set; }
        public string fullName { get; set; }
        public string address { get; set; }
        public string phoneNumber { get; set; }
        public ICollection<Review> Review { get; set; }
    }
}