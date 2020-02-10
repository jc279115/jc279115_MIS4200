using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace jc279115_MIS4200.Models
{
    public class Review
    {
        public int reviewID { get; set; }
        public string comments { get; set; }
        public DateTime submittedOn { get; set; }
        public int userID { get; set; }
        public virtual Users Users { get; set; }
        public int placeID { get; set; }
        public virtual Places Places { get; set; }

    }
}