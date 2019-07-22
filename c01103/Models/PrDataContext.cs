using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace c01103.Models
{
    public class PrDataContext : DbContext
    {
        public PrDataContext():base("Products"){ }
        public DbSet<Product> Products { get; set; }
    }
}