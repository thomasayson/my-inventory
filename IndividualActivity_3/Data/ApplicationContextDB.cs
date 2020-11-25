using IndividualActivity_3.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IndividualActivity_3.Data
{
    public class ApplicationContextDB : DbContext
    {
        public ApplicationContextDB(DbContextOptions<ApplicationContextDB> options) : base(options)
        {

        }

        public DbSet<Supplier> Suppliers { get; set; }
    }
}
