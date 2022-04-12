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
        public HashWebMvcContext (DbContextOptions<HashWebMvcContext> options)
            : base(options)
        {
        }

        public DbSet<HashWebMvc.Models.ViewModels.Department> Department { get; set; }
    }
}
