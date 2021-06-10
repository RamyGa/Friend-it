using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Threading.Tasks;


namespace Rent_it.Models
{
    public class DataContext : DbContext
    {
        public DataContext() : base() { }

        public DbSet<Customer> Customers { get; set; }

        public DbSet<Movie> Movies { get; set; }

     
    }
}
