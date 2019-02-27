using Microsoft.EntityFrameworkCore;

namespace ef3.Models
{
    public class ECommDBContext : DbContext
    {
         protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=Experts;Initial Catalog=ECommerce;Integrated Security=true;MultipleActiveResultSets=true;");
            base.OnConfiguring(optionsBuilder);
        }
        public DbSet<Form> Forms {get;set;}
    }
}