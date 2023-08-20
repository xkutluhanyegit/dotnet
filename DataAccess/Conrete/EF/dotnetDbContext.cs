using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Conrete.EF
{
    public class dotnetDbContext:DbContext
    {
        public dotnetDbContext()
        {
            
        }
        public dotnetDbContext(DbContextOptions<dotnetDbContext> options)
        :base(options)
        {
            
        }

        public DbSet<Products> products { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost;Database=dotnetDb;User Id=SA;Password=Airtes1991.;TrustServerCertificate=true");
        }
    }
}