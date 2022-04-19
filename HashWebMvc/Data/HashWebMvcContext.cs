using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using HashWebMvc.Models.ViewModels;

namespace HashWebMvc.Models
{
    public class HashWebMvcContext : DbContext
    {
        public HashWebMvcContext(DbContextOptions<HashWebMvcContext> options)
            : base(options)
        {
        }

        public DbSet<Department> Department { get; set; }
        public DbSet<Seller> Seller { get; set; }
        public DbSet<SalesRecord> SalesRecords { get; set; }

    }
}
