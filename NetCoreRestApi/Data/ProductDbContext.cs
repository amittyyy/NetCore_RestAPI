using Microsoft.EntityFrameworkCore;
using NetCoreRestApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreRestApi.Data
{
    //DbContext:- came from EFCore package, responsible to work with database
    public class ProductDbContext: DbContext
    {
        public ProductDbContext(DbContextOptions<ProductDbContext> options): base(options)
        {

        }
        public DbSet<Product> Products { get; set; }
        //public DbSet<Service> Services { get; set; }
    }
}
