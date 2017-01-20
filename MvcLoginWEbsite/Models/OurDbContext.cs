using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MvcLoginWEbsite.Models
{
    public class OurDbContext : DbContext
    {
        //This is userAccount property
        public DbSet<UserAccount> userAccount { get; set; } 
    }
}