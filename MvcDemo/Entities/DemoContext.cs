using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MvcDemo.Entities
{
    public class DemoContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
    }
}