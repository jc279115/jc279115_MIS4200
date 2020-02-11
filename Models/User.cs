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
        public string fullName { get; set; }
        public string userName { get; set; }
        public string passWord { get; set; }
        public string email { get; set; }
        public string phoneNumber { get; set; }
        public DateTime publishDate { get; set; }
        public ICollection<Review> Review { get; set; }
        
    }
}