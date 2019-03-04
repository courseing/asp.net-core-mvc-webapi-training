using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPIManageProducts.Model
{
    public class ECommDBContext : DbContext
    {
        public DbSet<Form> Forms { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=Experts;Initial Catalog=ECommerce;Integrated Security=true;MultipleActiveResultSets=true;");
            base.OnConfiguring(optionsBuilder);
        }
    }

}
