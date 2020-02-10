﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using jc279115_MIS4200.Models; // This is needed to access the models
using System.Data.Entity; // this is needed to access the DbContext object

namespace jc279115_MIS4200.DAL
{
    public class MIS4200Context : DbContext
    {
        public MIS4200Context() : base("name=DefaultConnection")
        {

        }
        public DbSet<Users> Users { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Places> Places { get; set; }
    }

}