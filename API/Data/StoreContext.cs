using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    // Creating the DbContext class
    public class StoreContext : DbContext
    {
        // Pass DbContextOptions to the instance of StoreContext, as well as base constructor
        // Options will contain connection string
        public StoreContext(DbContextOptions options) : base(options)
        {

        }

        // DbSet representing Products db table
        public DbSet<Product> Products { get; set; }
    }
}