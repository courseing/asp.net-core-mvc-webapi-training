using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductManagement.Models
{
    public class ECommDBContext : DbContext
    {
        //private IConfiguration _config;

        //public ECommDBContext(DbContextOptions<ECommDBContext> options) : base(options) { }
        //public ECommDBContext(IConfiguration config, DbContextOptions<ECommDBContext> options) : base(options)
        //{
        //    _config = config;
        //}


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=Experts;Initial Catalog=Sample;Integrated Security=true;MultipleActiveResultSets=true;");
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

    }
}
